/*author: @Barkty
*/
using System;

class ArrayLeaders
{
    /*
        Complexity
        Time: O(n) → single pass from right to left.
        Space: O(k)
    */
    static void FindAllLeaders(int[] arr)
    {
        List<int> result = new List<int>();
        int n = arr.Length;

        int leader = arr[n - 1];
        result.Add(leader);

        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] >= leader)
            {
                leader = arr[i];
                result.Add(leader);
            }
        }

        result.Reverse();

        foreach (int res in result)
        {
            Console.Write(res + ", ");
        }
    }
    /*
        Complexity
        Time: O(n) → single pass from right to left.
        Space: O(k) -> leaders (stack), but no need to reverse a list
    */
    
    static void FindAllLeadersUsingStack(int[] arr)
    {
        int n = arr.Length;
        int leader = arr[n - 1];

        Stack<int> stack = new Stack<int>();
        stack.Push(leader);

        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] >= leader)
            {
                leader = arr[i];
                stack.Push(leader);
            }
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }
    }


    static void Main()
    {
        int[] arr1 = [ 16, 17, 4, 3, 5, 2 ];
        FindAllLeaders(arr1);  // Output: 17 5 2
        FindAllLeadersUsingStack(arr1);  // Output: 17 5 2

        Console.WriteLine();

        int[] arr2 = [ 1, 2, 3, 4, 5, 2 ];
        FindAllLeaders(arr2);  // Output: 5 2
        FindAllLeadersUsingStack(arr2);  // Output: 5 2
    }
}
