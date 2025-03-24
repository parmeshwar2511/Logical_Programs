
//class program
//{
//     static void Main()
//    {
//        int[] arr = { 12, 23, 34, 56, 67, 45, 86, 9, 91 };
//        int hightest = arr[0];

//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] > hightest)
//            {
//                hightest = arr[i];
//            }
//        }

//        Console.WriteLine("The Highest Number in The Array is : " + hightest);
//    }
//}

using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter the size of the array
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        // Declare an array with the given size
        int[] arr = new int[size];

        // Get user input to populate the array
        Console.WriteLine($"Enter {size} numbers:");
        for (int i = 0; i < size; i++)
        {
            //Console.Write($"Enter number {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Find the highest number
        int highest = arr[0]; // Assume first number is highest

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > highest)
            {
                highest = arr[i];
            }
        }

        // Display the highest number
        Console.WriteLine("The highest number in the array is: " + highest);
    }
}

// please Give Me a Number This Type 
//Enter the size of the array: 5
//Enter 5 numbers:
//10
//34
//45
//76
//98
//The highest number in the array is: 98


