using System;

class BinarySearch
{
    // ============================================================
    // Binary Search
    // ============================================================
    //
    // Binary Search requires a sorted array.
    //
    // Two implementations:
    // 1. Iterative Binary Search
    // 2. Recursive Binary Search
    //
    // Time Complexity:
    //     Both: O(log n)
    //
    // Space Complexity:
    //     Iterative: O(1)
    //     Recursive: O(log n) because of the call stack
    // ============================================================


    // ------------------------------------------------------------
    // 1. Iterative Binary Search
    // ------------------------------------------------------------

    public static int BinarySearchIterative(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (numbers[mid] == target)
            {
                return mid;
            }

            if (numbers[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }


    // ------------------------------------------------------------
    // 2. Recursive Binary Search
    // ------------------------------------------------------------

    public static int BinarySearchRecursive(
        int[] numbers,
        int target,
        int left,
        int right)
    {
        // Base case:
        // Search space is empty
        if (left > right)
        {
            return -1;
        }

        int mid = left + (right - left) / 2;

        if (numbers[mid] == target)
        {
            return mid;
        }

        if (numbers[mid] < target)
        {
            return BinarySearchRecursive(
                numbers,
                target,
                mid + 1,
                right);
        }

        return BinarySearchRecursive(
            numbers,
            target,
            left,
            mid - 1);
    }

    public static int FindFirst(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        int answer = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (numbers[mid] == target)
            {
                answer = mid;
                right = mid - 1;
            }
            else if (numbers[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return answer;
    }


    public static int FindLast(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        int answer = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (numbers[mid] == target)
            {
                answer = mid;
                left = mid + 1;
            }
            else if (numbers[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return answer;
    }

    // ------------------------------------------------------------
    // Public wrapper for easier use
    // ------------------------------------------------------------

    public static int Search(int[] numbers, int target)
    {
        return BinarySearchRecursive(
            numbers,
            target,
            0,
            numbers.Length - 1);
    }


    // ------------------------------------------------------------
    // Tests
    // ------------------------------------------------------------

    static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };


        // Iterative tests

        if (BinarySearchIterative(numbers, 11) != 5)
            throw new Exception("Iterative test failed.");

        if (BinarySearchIterative(numbers, 4) != -1)
            throw new Exception("Iterative test failed.");


        // Recursive tests

        if (Search(numbers, 11) != 5)
            throw new Exception("Recursive test failed.");

        if (Search(numbers, 4) != -1)
            throw new Exception("Recursive test failed.");


        // Edge cases

        int[] empty = { };

        if (BinarySearchIterative(empty, 5) != -1)
            throw new Exception("Empty array test failed.");

        if (Search(empty, 5) != -1)
            throw new Exception("Empty array test failed.");


        int[] single = { 5 };

        if (BinarySearchIterative(single, 5) != 0)
            throw new Exception("Single element test failed.");

        if (Search(single, 5) != 0)
            throw new Exception("Single element test failed.");


        Console.WriteLine("All Binary Search tests passed!");
        int[] num = { 1, 2, 2, 2, 2, 3, 4 };

        if (FindFirst(num, 2) != 1)
            throw new Exception("FindFirst failed.");

        if (FindLast(num, 2) != 4)
            throw new Exception("FindLast failed.");

        if (FindFirst(num, 5) != -1)
            throw new Exception("FindFirst not-found failed.");

        if (FindLast(num, 5) != -1)
            throw new Exception("FindLast not-found failed.");

        Console.WriteLine("First/Last occurrence tests passed!");
    }

}