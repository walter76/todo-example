namespace ToDo.Infrastructure;

using ToDo.Adapters;
using Task = Entities.Task;

public class InMemoryTasksRepository : ITasksRepository
{
    private List<Task> _tasks = new();

    public void CreateTask(Task task)
    {
        _tasks.Add(task);
    }

    public void DeleteTask(Guid id)
    {
        _tasks.RemoveAll(t => t.Id == id);
    }

    public void UpdateTask(Task task)
    {
        var existingTask = _tasks.Find(t => t.Id == task.Id);
        existingTask.Title = task.Title;
        existingTask.IsCompleted = task.IsCompleted;
    }

    public Task FindTask(Guid id)
    {
        return _tasks.Find(t => t.Id == id);
    }
    
    public IReadOnlyCollection<Task> GetTasks()
    {
        return _tasks;
    }
}