using System.Windows;

namespace WPF_Task;

public partial class AddTaskWindow : Window
{
    public string TaskTitle { get; private set; }
    public string TaskDescription { get; private set; }
    public AddTaskWindow()
    {
        InitializeComponent();
    }
    private void OkButton_Click(object sender, RoutedEventArgs e)
    {
        TaskTitle = TitleTextBox.Text;
        TaskDescription = DescriptionTextBox.Text;
        DialogResult = true;
        Close();
    }
}