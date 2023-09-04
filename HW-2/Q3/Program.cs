namespace Q3;

class Program 
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        char[] vovels = { 'a', 'e', 'i', 'o', 'u' };
        List<char> vovelsList = new List<char>(vovels);
        foreach(char c in line)
        {
            if (vovels.Contains(c))
            {
                vovelsList.Add(c);
            }
        }
        vovelsList.Sort();
        foreach(char c in vovelsList)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}