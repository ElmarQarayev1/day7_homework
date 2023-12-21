namespace FindAletter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("bir yazi daxil edin");
        string word = Console.ReadLine();
        bool check = false;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'A')
            {
                check = true;
                break;
            }

        }
        if (check)
        {
            Console.WriteLine("yazinin icinde A herfi var");
        }
        else
        {
            Console.WriteLine("yazinin icinde A herfi yoxdur");
        }
        Console.ReadLine();

    }
}