using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WPF_Task;

public partial class MainWindow : Window
{
    
    private const string FilePath = "tasks.json";
    public MainWindow()
    {
        InitializeComponent(); 
        LoadTasks(); // Загружает задачи из файла при инициализации окна
    }
    
    protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
    {
        SaveTasks();// Сохраняет задачи в файл перед закрытием окна
        base.OnClosing(e);
    }
    
    /// <summary>
    /// Начинает операцию перетаскивания, если выбран элемент в ListBox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        ListBox? listBox = sender as ListBox;
        if (listBox != null && listBox.SelectedItem != null)
        {
            DragDrop.DoDragDrop(listBox, listBox.SelectedItem, DragDropEffects.Move);
        }
    }
    
    /// <summary>
    /// Обрабатывает сброс элемента в другой ListBox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListBox_Drop(object sender, DragEventArgs e)
    {
        ListBox targetListBox = sender as ListBox;
        string taskTitle = e.Data.GetData(typeof(string)) as string;

        if (targetListBox != null && taskTitle != null)
        {
            ListBox sourceListBox = GetSourceListBox(taskTitle);

            if (sourceListBox != null)
            {
                sourceListBox.Items.Remove(taskTitle);
                targetListBox.Items.Add(taskTitle);
                
                targetListBox.SelectedItem = null;
                Keyboard.ClearFocus();
            }
        }
    }
    
    /// <summary>
    /// Устанавливает эффект перетаскивания и предотвращает дальнейшую обработку события
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListBox_DragOver(object sender, DragEventArgs e)
    {
        // 
        e.Effects = DragDropEffects.Move;
        e.Handled = true;
    }

    /// <summary>
    /// Возвращает ListBox, содержащий указанный элемент
    /// </summary>
    /// <param name="taskTitle"></param>
    /// <returns></returns>
    private ListBox GetSourceListBox(string taskTitle)
    {
        if (ToDoListBox.Items.Contains(taskTitle))
        {
            return ToDoListBox;
        }
        if (InProgressListBox.Items.Contains(taskTitle))
        {
            return InProgressListBox;
        }
        if (DoneListBox.Items.Contains(taskTitle))
        {
            return DoneListBox;
        }
        return null;
    }
    
    private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        ListBox listBox = sender as ListBox;
        if (listBox != null && listBox.SelectedItem != null)
        {
            string currentTitle = listBox.SelectedItem.ToString();
            var editWindow = new EditTaskWindow(currentTitle);

            if (editWindow.ShowDialog() == true)
            {
                string newTitle = editWindow.TaskTitle;
                if (!string.IsNullOrWhiteSpace(newTitle))
                {
                    int selectedIndex = listBox.SelectedIndex;
                    listBox.Items[selectedIndex] = newTitle;
                }
            }
        }
    }
    
    /// <summary>
    /// Сохраняет текущие задачи в файл в формате JSON
    /// </summary>
    private void SaveTasks()
    {
        var tasks = new List<TaskItem>();

        foreach (var item in ToDoListBox.Items)
        {
            tasks.Add(new TaskItem { Title = item.ToString(), Status = "To Do" });
        }

        foreach (var item in InProgressListBox.Items)
        {
            tasks.Add(new TaskItem { Title = item.ToString(), Status = "In Progress" });
        }

        foreach (var item in DoneListBox.Items)
        {
            tasks.Add(new TaskItem { Title = item.ToString(), Status = "Done" });
        }

        var json = JsonSerializer.Serialize(tasks);
        File.WriteAllText(FilePath, json);
    }
    
    /// <summary>
    /// Загружает задачи из файла и распределяет их по соответствующим ListBox
    /// </summary>
    private void LoadTasks()
    {
        if (!File.Exists(FilePath))
            return;

        var json = File.ReadAllText(FilePath);
        var tasks = JsonSerializer.Deserialize<List<TaskItem>>(json);

        ToDoListBox.Items.Clear();
        InProgressListBox.Items.Clear();
        DoneListBox.Items.Clear();

        foreach (var task in tasks)
        {
            switch (task.Status)
            {
                case "To Do":
                    ToDoListBox.Items.Add(task.Title);
                    break;
                case "In Progress":
                    InProgressListBox.Items.Add(task.Title);
                    break;
                case "Done":
                    DoneListBox.Items.Add(task.Title);
                    break;
            }
        }
    }
    
    /// <summary>
    /// Добавляет новую задачу в список "To Do"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void AddTask_Click(object sender, RoutedEventArgs e)
    {
        //сначала так
        //ToDoListBox.Items.Add("New Task");
        //потом вот так:
        var addTaskWindow = new AddTaskWindow();
        if (addTaskWindow.ShowDialog() == true)
        {
            string title = addTaskWindow.TaskTitle;
            string description = addTaskWindow.TaskDescription;

            if (!string.IsNullOrWhiteSpace(title))
            {
                var newTask = new TaskItem { Title = title, Description = description, Status = "To Do" };
                ToDoListBox.Items.Add(newTask);
            }
        }
    }
    
    /// <summary>
    /// Перемещает выбранную задачу из "To Do" в "In Progress"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveToInProgress_Click(object sender, RoutedEventArgs e)
    {
        if (ToDoListBox.SelectedItem != null)
        {
            InProgressListBox.Items.Add(ToDoListBox.SelectedItem);
            ToDoListBox.Items.Remove(ToDoListBox.SelectedItem);
        }
    }
    
    /// <summary>
    /// Перемещает выбранную задачу из "To Do" или "In Progress" в "Done"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveToDone_Click(object sender, RoutedEventArgs e)
    {
        if (ToDoListBox.SelectedItem != null)
        {
            DoneListBox.Items.Add(ToDoListBox.SelectedItem);
            ToDoListBox.Items.Remove(ToDoListBox.SelectedItem);
        }
        else if (InProgressListBox.SelectedItem != null)
        {
            DoneListBox.Items.Add(InProgressListBox.SelectedItem);
            InProgressListBox.Items.Remove(InProgressListBox.SelectedItem);
        }
    }
    
    /// <summary>
    /// Перемещает выбранную задачу из "In Progress" или "Done" в "To Do"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoveToToDo_Click(object sender, RoutedEventArgs e)
    {
        if (InProgressListBox.SelectedItem != null)
        {
            ToDoListBox.Items.Add(InProgressListBox.SelectedItem);
            InProgressListBox.Items.Remove(InProgressListBox.SelectedItem);
        }
        else if (DoneListBox.SelectedItem != null)
        {
            ToDoListBox.Items.Add(DoneListBox.SelectedItem);
            DoneListBox.Items.Remove(DoneListBox.SelectedItem);
        }
    }
    
    /// <summary>
    /// Отменяет открытие контекстного меню, если нет выбранного элемента
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListBox_ContextMenuOpening(object sender, ContextMenuEventArgs e)
    {
        ListBox listBox = sender as ListBox;
        if (listBox != null && listBox.SelectedItem == null)
        {
            e.Handled = true;
        }
    }
}