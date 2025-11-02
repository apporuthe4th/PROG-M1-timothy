namespace math;

class Program
{
    static void Main(string[] args)
    {
        double kleiner = 9;
        double groter = 19;
        string? input = Console.ReadLine();
        int selected = int.Parse(input ?? "0"); 
        double welkeIsKleiner = Math.Min(kleiner, groter);
        double welkeIsgroter = Math.Max(kleiner, groter);
        bool minmax = Math.Clamp(10, kleiner, 20) == selected;
        Console.WriteLine($" tussen {kleiner} en {groter} is: {welkeIsKleiner} het kleinste getal");
        Console.WriteLine($" tussen {kleiner} en {groter} is: {welkeIsgroter} het grootste getal");
        Console.WriteLine(Math.Sqrt(kleiner));
        if (minmax)
        {
            Console.WriteLine($" {selected} is binnen de grenzen van 10 en 20");
        }
        else
        {
            Console.WriteLine($" {selected} is buiten de grenzen van 10 en 20");
        }
    }
}
