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

    public TasksListController(ILogger<TasksListController> logger)
    {
        _logger = logger;
        _tasksList = new TasksList(new InMemoryTasksRepository());
    }

    [HttpPost]
    public ActionResult<TaskDTO> CreateTask([FromQuery] string title)
    {
        var taskId = _tasksList.AddTask(title);

        var task = _tasksList.GetTask(taskId);
        return new TaskDTO(task);
    }
}
