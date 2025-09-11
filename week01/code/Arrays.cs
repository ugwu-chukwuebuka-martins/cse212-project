public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /* 
           Create an array result and make the given length its capacity,
           Write a for loop which appends a value to the array result
           by multiplying the given number and (i+1),
           return the array result
        */

        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        /* 
           Use an if statement to check if the list (data) is null or the length of the list (data) is 0,
           or the amount is less than or equal to 0.
           return the list (data)
           Create an integer count, which its value will be eqaul to the length of the list (data)
           Reassign the integer amount to be equal to (amount % count)
           Check if the amount is equal to 0 and return the list (data)
           Create a new list (rotated)
           Use the AddRange and GetRange function to add values to the list rotated,
           return the list rotated. 
        */
        if (data == null || data.Count == 0 || amount <= 0)
            return data;

        int count = data.Count;
        amount = amount % count; // Handle rotations greater than list size

        if (amount == 0)
            return data;

        List<int> rotated = new List<int>(count);
        rotated.AddRange(data.GetRange(count - amount, amount)); // Last 'amount' elements
        rotated.AddRange(data.GetRange(0, count - amount));      // Remaining elements

        return rotated;
    }
}
