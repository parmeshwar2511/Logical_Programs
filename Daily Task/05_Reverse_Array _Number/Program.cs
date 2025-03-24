
using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize an array
        int[] arr = { 1, 2, 3, 4, 5, 6 };

        // Print original array
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        // Reverse the array
        ReverseArray(arr);

        // Print reversed array
        Console.WriteLine("\nReversed Array:");
        PrintArray(arr);
    }

    // Method to reverse the array
    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            // Swap the elements
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            // Move pointers
            start++;
            end--;
        }
    }

    // Method to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}



