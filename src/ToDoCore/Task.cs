namespace ToDoCore;

public class Task
{
    public Guid Id { get; private set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
        IsCompleted = false;
    }
}
