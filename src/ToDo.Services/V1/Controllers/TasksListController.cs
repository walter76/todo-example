namespace ToDo.Services.V1.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class TasksListController : ControllerBase
{
    private readonly ILogger<TasksListController> _logger;

    private ITasksListService _tasksListService;

    public TasksListController(ILogger<TasksListController> logger, ITasksListService tasksListService)
    {
        _logger = logger;
        _tasksListService = tasksListService;
    }

    [HttpPost]
    public ActionResult<TaskDTO> CreateTask([FromQuery] string title)
    {
        return _tasksListService.CreateTask(title);
    }

    [HttpGet]
    public IEnumerable<TaskDTO> GetTasks()
    {
        return _tasksListService.GetTasks();
    }
}
