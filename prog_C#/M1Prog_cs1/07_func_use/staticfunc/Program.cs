namespace staticfunc;

class Program
{
    static void Main(string[] args)
    {




    }

    
    // static void SayHelloWorld() {

    //         Console.WriteLine("hello world");

    // }

    static void StopApp()
    {

        Console.WriteLine("Thank you, the app wil close now");

    }

    static void AfterIntro()
    {

        Console.WriteLine("Would you like to see the intro again? (y/n)");
        if (Console.ReadLine() == "y")
        {
            RestartApp();
        }
        else
        {
            StopApp();
        }

    }

    static void RestartApp()
    {

            Console.WriteLine("hello world");

    }
}

