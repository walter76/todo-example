namespace ToDo.Tests.Entities;

using ToDo.Entities;

public class TasksListTests
{
    [Test]
    public void NewlyCreatedTasksListShouldBeEmpty()
    {
        var tasksList = new TasksList();
        Assert.That(tasksList.GetTasks().Count, Is.Zero);
    }

    [Test]
    public void AddTaskShouldAddNewTask()
    {
        var tasksList = new TasksList();
        
        var taskId = tasksList.AddTask("Test task");

        Assert.That(tasksList.GetTasks().Count, Is.EqualTo(1));
        Assert.That(tasksList.GetTasks().First().Id, Is.EqualTo(taskId));
    }

    [Test]
    public void RemoveTaskShouldDeleteTask()
    {
        var tasksList = new TasksList();
        var taskId = tasksList.AddTask("Test task");

        tasksList.RemoveTask(taskId);
        
        Assert.That(tasksList.GetTasks().Count, Is.Zero);
    }
}