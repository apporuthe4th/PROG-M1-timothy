using System.Runtime.CompilerServices;

namespace AND;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("find dem keys");
        Console.WriteLine("TYPE Y1, Y2 / N1, N2");

        bool hasKey = Console.ReadLine() == "Y1";
        bool doorNeedKey = Console.ReadLine() == "Y2";

        if (doorNeedKey && hasKey == true && true)
        {
            Console.WriteLine("doorworky");
        }

        if (doorNeedKey && hasKey == false && true)
        {
            Console.WriteLine("Door does not need key");
        }
        if (doorNeedKey && hasKey == true && false) ;
        {
            Console.WriteLine("nokey");
        }
        if (doorNeedKey && hasKey == true && false) ;
        {
        Console.WriteLine("both false")
    }
    }
}
