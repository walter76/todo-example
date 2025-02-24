namespace ToDo.Entities;

public class TasksList
{
    private List<Task> _tasks = new();

    public Guid AddTask(string title)
    {
        var task = new Task(title);
        
        _tasks.Add(task);

        return task.Id;
    }

    public void RemoveTask(Guid id)
    {
        _tasks.RemoveAll(t => t.Id == id);
    }

    public void CompleteTask(Guid id)
    {
        var task = _tasks.Find(t => t.Id == id);
        task.IsCompleted = true;
    }

    public Task GetTask(Guid id)
    {
        return _tasks.Find(t => t.Id == id);
    }
    
    public IReadOnlyCollection<Task> GetTasks()
    {
        return _tasks;
    }
}
