namespace ALS;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Je zoekt je sleutel");
        Console.WriteLine("Heb je de sleutel gevonden? (Y/N)");
        string antwoord = Console.ReadLine();

        if (antwoord.ToUpper() == "Y")
        {
            Console.WriteLine("De deur gaat open en je kan naar binnen");
        }
        else if (antwoord.ToUpper() == "N")
        {
            Console.WriteLine("Je bent je sleutel kwijt!");
            Console.WriteLine("De deur blijft gesloten");
        }
        else
        {
            Console.WriteLine("Ongeldig antwoord. Voer Y of N in.");
        }
    }
}
