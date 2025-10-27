namespace OF;

class Program
{
    static void Main(string[] args)
    {
        int burger = 1;
        int pipebomb = 2;
        int chloroform_rag = 0;
        // FRUITEN

        int keuze = int.Parse(Console.ReadLine());
 

        if (keuze == chloroform_rag || keuze == pipebomb)
        {
            Console.WriteLine("very good choice");
        }
        
        if (keuze == burger)
        {
            Console.WriteLine("please no");
        }
    }
}
