using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The input is a palindrome.");
        }
        else
        {
            Console.WriteLine("The input is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        
        str = str.Replace(" ", "").ToLower();

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false; 
            }
            left++;
            right--;
        }

        return true; 
    }
}
