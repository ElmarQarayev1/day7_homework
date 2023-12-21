namespace kvadrataYukseltme;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("bir eded daxil edin: ");

        int eded;
        do
        {
            eded = Convert.ToInt32(Console.ReadLine());


        } while (eded <= 0 || eded % 2 != 0);
        int w = eded * eded;

        Console.WriteLine("ededin kvadrati: " + w);


        Console.ReadLine();

    }
}
