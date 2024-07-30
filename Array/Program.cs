

using System;

class Array {
    public static int search(int[] arr, int L, int x)
    {
        for (int i = 0; i < L; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

    // Driver's code
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int x = 4;

        // Function call
        int result = search(arr, arr.Length, x);
        if (result == -1)
            Console.WriteLine(
                "Element is not present in array");
        else
            Console.WriteLine("Element is present at index "
                              + result);
    }
}
