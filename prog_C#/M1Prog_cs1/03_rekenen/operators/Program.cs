namespace operators;
// maak nu zelf:

//     een int met een waarde
//         haal daar een getal af met -=
//         zet het resultaat op het scherm

//     een double met een waarde
//         doe die keer een getal met *=
//         zet het resultaat op het scherm

//     een float met een waarde
//         deel die door een getal met /=
//         zet het resultaat op het scherm

class Program
{
    static void Main(string[] args)
    {
        
        int min = 100;
        min -= 50;
        Console.WriteLine($"Het resultaat van min is: {min}");
    

        double keer = 12.5;
        keer *= 2;
        Console.WriteLine($"Het resultaat van keer is: {keer}");
        
        float deel = 9.6f;
        deel /= 3;
        Console.WriteLine($"Het resultaat van deel is: {deel}");
    }
}