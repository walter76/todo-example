namespace ToDo.Services;

public class TaskDTO
{
    public Guid? Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
}
