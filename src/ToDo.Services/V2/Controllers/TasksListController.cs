namespace ToDo.Services.V2.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.5")]
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

    [HttpPut]
    public ActionResult<TaskDTO> CompleteTask([FromQuery] string id)
    {
        return _tasksListService.CompleteTask(id);
    }
}
