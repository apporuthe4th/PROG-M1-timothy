namespace ialsindex;

class Program
{
    static void Main(string[] args)
    {
        var i = 0;
        var i_OLD = i;
        string[] slopmuch = new string[]
        {
            "ツユ",
            "アド",
            "ケンシ",
            "ヨネズ",
            "THIS",
            "IS",
            "A",
            "COOL",
            "WORD!",
            "I",
            "LIKE",
            "MUSIC!",
        };
        //  foreach (string text in slopmuch)
        // {
        //     Console.WriteLine($"{Array.IndexOf(slopmuch, text)}: {text}");
        // }



        foreach (string text in slopmuch)
        {
            if (i != i_OLD)
            {
                i += 1;
                Console.WriteLine($"{i}: {slopmuch[i]}");
            }

            else
            {
                Console.WriteLine($"{i}: {slopmuch[i]}");
                i += 1;
            }

        }
    }
}

