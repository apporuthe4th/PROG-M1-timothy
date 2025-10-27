namespace direct;

class Program
{
    static void Main(string[] args)
    {
        double[] direct = new double[] { 11.4, 22.2, 33.2, 44.4, 55.5 };
        
        foreach (double number in direct)
        {
            Console.WriteLine($"{number} - waarde op plek {Array.IndexOf(direct, number)}");
        }       
    }
}
