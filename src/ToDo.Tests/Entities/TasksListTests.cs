namespace ToDo.Tests.Entities;

using ToDo.Entities;
using ToDo.Infrastructure;

public class TasksListTests
{
    [Test]
    public void NewlyCreatedTasksListShouldBeEmpty()
    {
        var tasksList = new TasksList(new InMemoryTasksRepository());
        Assert.That(tasksList.GetTasks().Count, Is.Zero);
    }

    [Test]
    public void AddTaskShouldAddNewTask()
    {
        var tasksList = new TasksList(new InMemoryTasksRepository());

        var taskId = tasksList.AddTask("Test task");

        Assert.That(tasksList.GetTasks().Count, Is.EqualTo(1));
        Assert.That(tasksList.GetTasks().First().Id, Is.EqualTo(taskId));
    }

    [Test]
    public void RemoveTaskShouldDeleteTask()
    {
        var tasksList = new TasksList(new InMemoryTasksRepository());
        var taskId = tasksList.AddTask("Test task");

        tasksList.RemoveTask(taskId);
        
        Assert.That(tasksList.GetTasks().Count, Is.Zero);
    }

    [Test]
    public void GetTaskShouldReturnTask()
    {
        var tasksList = new TasksList(new InMemoryTasksRepository());
        var taskId = tasksList.AddTask("Test task");

        var task = tasksList.GetTask(taskId);
        
        Assert.That(task.Id, Is.EqualTo(taskId));
        Assert.That(task.Title, Is.EqualTo("Test task"));
    }

    [Test]
    public void GetTaskShouldReturnNullIfTaskNotFound()
    {
        var tasksList = new TasksList(new InMemoryTasksRepository());

        var task = tasksList.GetTask(Guid.NewGuid());
        
        Assert.That(task, Is.Null);
    }

    [Test]
    public void CompleteTaskShouldCompleteTask()
    {
        var tasksList = new TasksList(new InMemoryTasksRepository());
        var taskId = tasksList.AddTask("Test task");

        tasksList.CompleteTask(taskId);

        var task = tasksList.GetTask(taskId);
        Assert.That(task.IsCompleted, Is.True);
    }
}