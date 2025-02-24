namespace ToDo.Entities;

using ToDo.Adapters;

public class TasksList
{
    private ITasksRepository _tasksRepository;

    public TasksList(ITasksRepository tasksRepository)
    {
        _tasksRepository = tasksRepository;
    }

    public Guid AddTask(string title)
    {
        var task = new Task(title);
        
        _tasksRepository.CreateTask(task);

        return task.Id;
    }

    public void RemoveTask(Guid id)
    {
        _tasksRepository.DeleteTask(id);
    }

    public void CompleteTask(Guid id)
    {
        var task = _tasksRepository.FindTask(id);

        task.IsCompleted = true;

        _tasksRepository.UpdateTask(task);
    }

    public Task GetTask(Guid id)
    {
        return _tasksRepository.FindTask(id);
    }

    public IReadOnlyCollection<Task> GetTasks()
    {
        return _tasksRepository.GetTasks();
    }
}
