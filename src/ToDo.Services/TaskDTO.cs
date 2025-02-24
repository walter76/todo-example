namespace ToDo.Services;

using ToDo.Entities;

public class TaskDTO
{
    public Guid? Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public TaskDTO(Task task)
    {
        Id = task.Id;
        Title = task.Title;
        IsCompleted = task.IsCompleted;
    }
}
