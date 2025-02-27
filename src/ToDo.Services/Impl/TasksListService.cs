namespace ToDo.Services.Impl;

using ToDo.Entities;
using ToDo.Infrastructure;

public class TasksListService : ITasksListService
{
    private readonly ILogger<TasksListService> _logger;

    private TasksList _tasksList;

    public TasksListService(ILogger<TasksListService> logger)
    {
        _logger = logger;
        _tasksList = new TasksList(new InMemoryTasksRepository());
    }

    public TaskDTO CreateTask(string title)
    {
        var taskId = _tasksList.AddTask(title);

        var task = _tasksList.GetTask(taskId);
        return new TaskDTO(task);
    }

    public IEnumerable<TaskDTO> GetTasks()
    {
        return _tasksList.GetTasks().Select(task => new TaskDTO(task));
    }

    public TaskDTO CompleteTask(string id)
    {
        var taskId = Guid.Parse(id);
        
        _tasksList.CompleteTask(taskId);

         var task = _tasksList.GetTask(taskId);
       return new TaskDTO(task);
    }
}