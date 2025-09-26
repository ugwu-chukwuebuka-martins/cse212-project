using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following value and priority: Bob (2), Tim (1)
    // Expected Result: Bob
    // Defect(s) Found: No defect found
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 1);
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Loop through the list (value) and the list (priority), enqueue the values to the PriorityQueue
    // Expected Result: Goerge
    // Defect(s) Found: No defect found
    public void TestPriorityQueue_2()
    {
        List<string> value = ["Tim", "Sue", "Goerge"];
        List<int> priority = [5, 4, 7];
        var priorityQueue = new PriorityQueue();
        for (int i = 0; i < value.Count; i++)
        {
            priorityQueue.Enqueue(value[i], priority[i]);
        }

        Assert.AreEqual("Goerge", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
[TestMethod]
    // Scenario: Create a queue with the following value and priority: Bob (2), Tim (3), Sue (3)
    // Expected Result: Tim
    // Defect(s) Found: No defect found
    public void TestPriorityQueue_3()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 3);
        var sue = new PriorityItem("Sue", 3);

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
    }
}