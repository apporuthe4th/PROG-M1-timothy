namespace OF;

class Program
{
    static void Main(string[] args)
    {
        int chloroform_rag = 0;
        int burger = 1;
        int pipebomb = 2;
        int hydrogen_bomb = 3;
        int honda_civic = 4;
        
        
        // FRUITEN

        int keuze = int.Parse(Console.ReadLine());
 

        if (keuze == chloroform_rag || keuze == pipebomb)
        {
            Console.WriteLine("very good choice");
        }
        else if (keuze == hydrogen_bomb || keuze == honda_civic)
        {
            Console.WriteLine("a man of culture. i see");
        }
        else if (keuze == burger)
        {
            Console.WriteLine("please no");
        }
    }
}
