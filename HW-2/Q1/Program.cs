using System.Collections;

namespace hw2;
class Program
{

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number <= 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {

        ArrayList primeNumbers = new ArrayList();
        ArrayList nonPrimeNumbers = new ArrayList();

        for (int i = 0; i < 20; i++)
        {
            
            int n = int.Parse(Console.ReadLine());
            if (IsPrime(n))
            {
                primeNumbers.Add(n);
            }
            else
            {
                nonPrimeNumbers.Add(n);
            }   
        }

        Console.WriteLine("Prime Numbers: ");

        foreach (int prime in primeNumbers)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Non-Prime Numbers:");
        
        foreach (int nonPrime in nonPrimeNumbers)
        {
            Console.Write(nonPrime + " ");
        }
        Console.WriteLine();
    }
}