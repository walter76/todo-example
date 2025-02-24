using Microsoft.AspNetCore.Mvc;

namespace ToDo.Services.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksListController : ControllerBase
{
    private readonly ILogger<TasksListController> _logger;

    public TasksListController(ILogger<TasksListController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public ActionResult<TaskDTO> CreateTask([FromBody] TaskDTO taskDTO)
    {
        return new TaskDTO();
    }
}
