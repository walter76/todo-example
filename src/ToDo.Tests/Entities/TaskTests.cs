namespace ToDo.Tests.Entities;

using ToDo.Entities;

public class TaskTests
{
    [Test]
    public void NewlyCreatedTaskShouldNotBeCompleted()
    {
        var task = new Task("Test task");
        Assert.That(task.IsCompleted, Is.False);
    }
}
