namespace ToDoCore.Tests;

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
        tasksList.AddTask("Test task");
        Assert.That(tasksList.GetTasks().Count, Is.EqualTo(1));
        Assert.That(tasksList.GetTasks()[0].Title, Is.EqualTo("Test task"));
    }

    [Test]
    public void RemoveTaskShouldDeleteTask()
    {
        var tasksList = new TasksList();
        var task = tasksList.AddTask("Test task");

        tasksList.Remove(task.Id);
        
        Assert.That(tasksList.GetTasks().Count, Is.Zero);
    }
}