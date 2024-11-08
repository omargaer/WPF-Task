using System.Windows;

namespace WPF_Task;

public partial class EditTaskWindow : Window
{
    public EditTaskWindow()
    {
        InitializeComponent();
    }
    public string TaskTitle { get; private set; }

    public EditTaskWindow(string currentTitle)
    {
        InitializeComponent();
        TaskTitleTextBox.Text = currentTitle;
    }

    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        TaskTitle = TaskTitleTextBox.Text;
        DialogResult = true;
        Close();
    }
}