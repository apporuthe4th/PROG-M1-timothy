using Microsoft.VisualBasic;

namespace ALS;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("sleutel zoek");
        Console.WriteLine("Y/N");

       
        bool sleutelKwijt = Console.ReadLine() == "N";
        
        if (sleutelKwijt == true)
        {
            Console.WriteLine("Je bent je sleutel kwijt!");
            Console.WriteLine("de deur blijft gesloten");

            Console.WriteLine("divorce the wife");


        }
            else
        
            {
                
                Console.WriteLine("deur is open, ");
            }
        
        
    }
}
