namespace bigDigit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("a ededini daxil edin");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b ededini daxil edin");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("c ededini daxil edin");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine($"{a} ededi en boyukdur");

        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine($"{b} ededi en boyukdur");

        }
        else
        {
            Console.WriteLine($"{c} ededi en boyukdur");
        }
        Console.ReadLine();

    }
}