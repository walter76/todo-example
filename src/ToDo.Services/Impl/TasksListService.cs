namespace ToDo.Services.Impl;

using ToDo.Entities;

public class TasksListService
{
    private readonly ILogger<TasksListService> _logger;

    private TasksList _tasksList;

    public TasksListService(ILogger<TasksListService> logger, TasksList tasksList)
    {
        _logger = logger;
        _tasksList = tasksList;
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
}