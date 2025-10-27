namespace ALS;
class Program
{
//     • zorg dat je de booleans kan aanpassen, gebruik Console.ReadLine
// • test alle mogelijkheden van true/false
// o true/false
// doorNeedsKey? y/n
// Y
// player hasKey? y/n
// n
// je staat voor een deur
// de deur zit op slot
// o false/false
// doorNeedsKey? y/n
// n
// player hasKey? y/n
// n
// je staat voor een deur
// o false/true
// doorNeedsKey? y/n
// n
// player hasKey? y/n
// Y
// je staat voor een deur
// o true/true
// doorNeedsKey? y/n
// player hasKey? y/n
// je staat voor een deur
// de deur zit op slot
// je gebruikt de sleutel om de deur te openen
    static void Main(string[] args)
    {
        bool doorNeedsKey = true;
        bool hasKey = false;
        string antwoord = Console.ReadLine();

        Console.WriteLine("Je zoekt je sleutel");
        Console.WriteLine("Heb je de sleutel gevonden? (Y/N)");
           Console.WriteLine($"Door unlocked? {doorNeedsKey}");
           Console.WriteLine($"Heb je sleutel? {hasKey}");

        if (antwoord.ToUpper() == "Y" && doorNeedsKey == true && hasKey == true)
        {
            Console.WriteLine("De deur gaat open en je kan naar binnen");
        }
        else if (antwoord.ToUpper() == "Y" && doorNeedsKey == true && hasKey == false)
        {
            Console.WriteLine("De deur blijft gesloten. Geen sleutel");
        }



        if (antwoord.ToUpper() == "N" && doorNeedsKey == false)
        {
            Console.WriteLine("Je staat voor een deur");
            Console.WriteLine("De deur is open, je kan naar binnen");
        }
        else if (antwoord.ToUpper() == "N" && doorNeedsKey == true)
        {
            Console.WriteLine("Je bent je sleutel kwijt!");
            Console.WriteLine("De deur blijft gesloten");
        }


        if (antwoord.ToUpper() != "Y" && antwoord.ToUpper() != "N")
        {
            Console.WriteLine("Ongeldig antwoord. Voer Y of N in.");
        }


        
    }
}
