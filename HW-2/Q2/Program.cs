namespace Q2;

class Program 
{
    static void Main(string[] args)
    {
        int[] numbers = new int[20];
        int smallest = 0;
        int biggest = 0;
        Console.WriteLine("Enter 20 numbers: ");
        for (int i = 0; i < 20; i++)
        {
            
            int n = int.Parse(Console.ReadLine());
            numbers[i] = n; 
        }
        Array.Sort(numbers);
        Console.WriteLine("Smallest 3 numbers: ");
        for(int i = 0; i < 3; i++)
        {
            smallest += numbers[numbers.Count()-i-1];
            Console.Write(numbers[numbers.Count()-i-1] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Average of smallest 3 numbers: " + smallest/3.0);
        Console.WriteLine("Biggest 3 numbers: ");
        for(int i = 0; i < 3; i++)
        {
            biggest += numbers[i];
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Average of biggest 3 numbers: " + biggest/3.0);
    }
}