namespace autoclass;

class Auto
{
    internal string merk;
    internal int bouwjaar;

    static void Main(string[] args)
    {
        Auto mijnAuto = new Auto();

        mijnAuto.merk = "BMW";
        mijnAuto.bouwjaar = 2001;

        Console.WriteLine(mijnAuto);
        Console.WriteLine("Auto merk: " + mijnAuto.merk);
        Console.WriteLine("bouwdatum: " + mijnAuto.bouwjaar);
    }
}
