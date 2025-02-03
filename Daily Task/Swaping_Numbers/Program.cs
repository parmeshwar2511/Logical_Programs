
//class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 22;
//        int b = 40;
//        Console.WriteLine($"a : {a} b : {b}");
//        a = a + b;
//        b = a - b;
//        a = a - b;
//        Console.WriteLine($"After swap a: {a}");
//        Console.WriteLine($"After swap b : {b}");

//        Console.ReadLine();
//    }
//}


class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers that u want to swap Number");
        int a = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"the numbers before swapping a:{a} and b:{b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"the numbers after swapping a:{a} and b:{b}");
    }
}