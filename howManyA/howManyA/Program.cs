namespace howManyA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("bir yazi daxil edin");
        string word = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'A')
            {
                count++;

            }

        }
        Console.WriteLine($"yazinin icinde {count} A herfi var");
        Console.ReadLine();
    }
}
