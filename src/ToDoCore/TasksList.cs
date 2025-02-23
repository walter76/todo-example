namespace ToDoCore;

public class TasksList
{
    private List<Task> _tasks = new();

    public void AddTask(string title)
    {
        _tasks.Add(new Task(title));
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
