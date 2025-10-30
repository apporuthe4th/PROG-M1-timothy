namespace arraycalc;

class Program
{
    static void Main(string[] args)
    {
        double[] bank = new double[] {240.99,
                                      1142.23,
                                      789.89,
                                      658.72};
            foreach (var item in bank)
        {
         
            Console.WriteLine($" {Array.IndexOf(bank, item)}: {item + 100}");  
    }
    }

}
