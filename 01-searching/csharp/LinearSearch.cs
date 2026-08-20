using System;

class LinearSearch
{
   public static int Search(int[] arr, int target)
    {
        for (int i =0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
            return -1;
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 7, 9 };
        int target = 5;
        int result = Search(arr, target);

        if (result != -1)
        {
            Console.WriteLine($"Element found at index: {result}");
        }
        else
        {
            Console.WriteLine("Element not found in the array.");
        }
    }
}

