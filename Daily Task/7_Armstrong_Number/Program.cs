
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Enter Any Number ");
        int num = int.Parse(Console.ReadLine());
    

        if (IsArmstrong(num))
            Console.WriteLine($"{num} this is armstrong Number.");
        else
            Console.WriteLine($"{num} this is not armstrong Number.");
    }

    static bool IsArmstrong(int num)
    {
        int sum = 0, temp = num;
        int digits = num.ToString().Length;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }

        return sum == num;

    }

}
