
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        Console.WriteLine($"Original: {word}");
        Console.WriteLine($"Reversed: {reversed}");

        Console.ReadLine();
    }
}

//using System;

//class Program
//{
//    static void Main()
//    {
//        string word = "Hello";

//        char[] charArray = word.ToCharArray();
//        Array.Reverse(charArray);
//        string reversed = new string(charArray);

//        Console.WriteLine($"Original: {word}");
//        Console.WriteLine($"Reversed: {reversed}");
//    }
//}


