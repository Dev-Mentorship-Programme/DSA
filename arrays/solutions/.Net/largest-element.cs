/*author: @Barkty
*/
using System;

class SecondLargestElement
{
    /*
        Complexity:

        Time: O(n) → only one scan.
        Space: O(1) → just two variables.
    */
    static int FindSecondLargest(int[] arr)
    {
        if (arr.Length < 2)
            return -1;

        int first = int.MinValue;
        int second = int.MinValue;

        foreach (int num in arr)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num > second && num < first)
            {
                second = num;
            }
        }

        return (second == int.MinValue) ? -1 : second;
    }

    static void Main()
    {
        int[] arr1 = [ 12, 35, 1, 10, 34, 1 ];
        Console.WriteLine(FindSecondLargest(arr1)); // 34

        int[] arr2 = [ 10, 5, 10 ];
        Console.WriteLine(FindSecondLargest(arr2)); // 5

        int[] arr3 = [ 10, 10, 10 ];
        Console.WriteLine(FindSecondLargest(arr3)); // -1
    }
}
