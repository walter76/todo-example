namespace ToDo.Adapters;

using Task = Entities.Task;

public interface ITasksRepository
{
    void CreateTask(Task task);
    void DeleteTask(Guid id);
    void UpdateTask(Task task);
    Task FindTask(Guid id);
    IReadOnlyCollection<Task> GetTasks();
}
