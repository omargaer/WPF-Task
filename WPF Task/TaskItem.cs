namespace WPF_Task;

public class TaskItem
{
    public string? Title { get; set; }
    public required string Status { get; set; } 
    public string? Description { get; set; } 
    public override string ToString()
    {
        return Title ?? string.Empty;
    }
}