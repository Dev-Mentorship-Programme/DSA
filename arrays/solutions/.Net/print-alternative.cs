/*author: @Barkty
*/
using System;

class PrintAlternative
{
    static void PrintAlternates(int[] arr) {
        for (int i = 0; i < arr.Length; i += 2) {
            Console.Write(arr[i] + " ");
        }
    }

    /** Time: O(n)
        Space: O(1)
    */
    static void Main()
    {
        int[] arr = [10, 20, 30, 40, 50];
        PrintAlternates(arr);
    }
}
