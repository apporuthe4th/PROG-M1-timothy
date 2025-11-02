namespace forfunc;

class Program
{
    static void Main(string[] args)
    {
        int[] basis = new int[] { 10, 20, 30, 40 };
        foreach (int getal in basis)
        {
            double resultaat = Math.Pow(getal, 2);
            Console.WriteLine($"kwadraat van {getal} is {resultaat}");
        }
    }
}
