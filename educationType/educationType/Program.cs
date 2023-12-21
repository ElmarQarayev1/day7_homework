namespace educationType;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("tehsil novunu daxil edin: ");

        string tn = Console.ReadLine();

        if (tn == "programming")
        {
            Console.WriteLine("400 saat");
        }
        else if (tn == "design")
        {
            Console.WriteLine("250 saat");
        }
        else if (tn == "system")
        {
            Console.WriteLine("200 saat");
        }
        else
        {
            Console.WriteLine("tehsil novu yanlisdir");
        }
        Console.ReadLine();
    }
}
