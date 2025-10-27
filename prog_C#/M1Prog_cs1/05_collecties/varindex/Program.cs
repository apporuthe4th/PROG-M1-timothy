namespace varindex;

class Program
{
    static void Main(string[] args)
    {


        string[] varindex = new string[] { "mario", "sonic", "spyro" };
        foreach (string character in varindex)
        {
            Console.WriteLine($" Type {Array.IndexOf(varindex, character)} voor {character}");
        }

int chosenchar = int.Parse(Console.ReadLine());
        if (chosenchar == 0) {
    Console.WriteLine ("mariooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo selectooo");
}
else if (chosenchar == 1) {
    Console.WriteLine ("sonicoooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo selectooo");
}
else if (chosenchar == 2) {
    Console.WriteLine ("spyrooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo selectooo");
}
    }

   

}
