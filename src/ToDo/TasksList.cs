namespace ToDo;

public class TasksList
{
    private List<Task> _tasks = new();

    public Task AddTask(string title)
    {
        var task = new Task(title);
        
        _tasks.Add(task);

        return task;
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

    public List<Task> GetTasks()
    {
        return _tasks;
    }
}
