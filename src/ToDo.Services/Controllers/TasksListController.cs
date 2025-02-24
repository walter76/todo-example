using Microsoft.AspNetCore.Mvc;
using ToDo.Entities;
using ToDo.Infrastructure;

namespace ToDo.Services.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksListController : ControllerBase
{
    private readonly ILogger<TasksListController> _logger;

    private TasksList _tasksList;

    public TasksListController(ILogger<TasksListController> logger, TasksList tasksList)
    {
        _logger = logger;
        _tasksList = tasksList;

        _logger.LogInformation("TasksListController created");
    }

    [HttpPost]
    public ActionResult<TaskDTO> CreateTask([FromQuery] string title)
    {
        var taskId = _tasksList.AddTask(title);

        var task = _tasksList.GetTask(taskId);
        return new TaskDTO(task);
    }

    [HttpGet]
    public IEnumerable<TaskDTO> GetTasks()
    {
        return _tasksList.GetTasks().Select(task => new TaskDTO(task));
    }
}
