namespace ToDo.Services;

public interface ITasksListService
{
    TaskDTO CreateTask(string title);
    IEnumerable<TaskDTO> GetTasks();
}
