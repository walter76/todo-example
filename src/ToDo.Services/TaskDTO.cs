namespace ToDo.Services;

using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;
using ToDo.Entities;

public class TaskDTO
{
    [Required]
    [SwaggerSchema("The unique identifier for the task")]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public TaskDTO(Task task)
    {
        Id = task.Id;
        Title = task.Title;
        IsCompleted = task.IsCompleted;
    }
}
