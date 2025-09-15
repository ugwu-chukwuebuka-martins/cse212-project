using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following value and priority: Bob (2), Tim (1)
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 1);

        PriorityItem[] expectedResult = [bob, tim];

        /* Dequee Start */
        if (expectedResult.Length == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        for (int index = 1; index < expectedResult.Length - 1; index++)
        {
            if (expectedResult[index].Priority >= expectedResult[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        var expectedValue = expectedResult[highPriorityIndex].Value;
        /* Dequeue End */

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);

        Assert.AreEqual(expectedValue, priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Loop through the list (value) and the list (priority), add the values and priority to the list (expectedResult)
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        List<string> value = ["Tim", "Sue", "Goerge"];
        List<int> priority = [5, 4, 7];
        List<PriorityItem> expectedResult = [];
        for (int i = 0; i < value.Count; i++)
        {
            var valP = new PriorityItem(value[i], priority[i]);
            expectedResult.Add(valP);
        }

        /* Dequee Start */
        if (expectedResult.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        for (int index = 1; index < expectedResult.Count - 1; index++)
        {
            if (expectedResult[index].Priority >= expectedResult[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        var expectedValue = expectedResult[highPriorityIndex].Value;
        /* Dequeue End */

        var priorityQueue = new PriorityQueue();
        for (int i = 0; i < value.Count; i++)
        {
            priorityQueue.Enqueue(value[i], priority[i]);
        }

        Assert.AreEqual(expectedValue, priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    public void TestPriorityQueue_3()
    {
        var bob = new PriorityItem("Bob", 2);
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 3);
        
        PriorityItem[] expectedResult = [bob, tim, sue, tim, bob];

       /* Dequee Start */
        if (expectedResult.Length == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        var highPriorityIndex = 0;
        for (int index = 1; index < expectedResult.Length - 1; index++)
        {
            if (expectedResult[index].Priority >= expectedResult[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        var expectedValue = expectedResult[highPriorityIndex].Value;
        /* Dequeue End */

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        
        Assert.AreEqual(expectedValue, priorityQueue.Dequeue());
    }
}