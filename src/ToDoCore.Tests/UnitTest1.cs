namespace ToDoCore.Tests;

public class TaskTests
{
    [Test]
    public void NewlyCreatedTaskShouldNotBeCompleted()
    {
        var task = new Task("Test task");
        Assert.That(task.IsCompleted, Is.False);
    }
}
