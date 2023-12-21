namespace arraydakiCem;

class Program
{
    static void Main(string[] args)
    {

        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"arraydaki {i + 1} ci ededi daxil edin:");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("arraydaki ededlerin cemi: " + sum);
        Console.ReadLine();
    }
}
