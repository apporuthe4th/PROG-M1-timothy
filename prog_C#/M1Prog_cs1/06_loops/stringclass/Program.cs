namespace stringclass;

class Program
{
    static void Main(string[] args)
    {
        string[] nameo = new string[] { "global", "variable", "class" };
        foreach (string item in nameo)
        {
            Console.WriteLine($" {item.Length} length: {item.ToUpper()} ");
        }
        
    }


}
