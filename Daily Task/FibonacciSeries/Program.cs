
public class program
{
    static void Main()
    {

        Console.WriteLine("Enter the number ");
        int n = int.Parse(Console.ReadLine());


        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonum(i));
        }
    }


    static int Fibonum(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonum(n - 1) + Fibonum(n - 2);
        }
    }
}