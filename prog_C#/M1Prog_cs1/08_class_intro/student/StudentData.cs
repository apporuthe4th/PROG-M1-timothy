using System;

namespace student
{
    class Student
    {

        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public string Studentnummer { get; set; }

        public override string ToString()
        {
            return $"Naam: {Naam}, Leeftijd: {Leeftijd}, Studentnummer: {Studentnummer}";
        }

        // Maak de methode public zodat andere code hem kan aanroepen.
        // Optionele parameter 'jaren' maakt het mogelijk meerdere jaren tegelijk toe te voegen.
        public void Verjaar(int jaren = 1)
        {
            Leeftijd += jaren;
        }

    }

    class StudentData
    {
        
        static void Main(string[] args)
        {

            var student1 = new Student { Naam = "ivan", Leeftijd = 16, Studentnummer = "123456" };
            var student2 = new Student { Naam = "yuuper", Leeftijd = 17, Studentnummer = "654321" };

            // Print waarden vóór de verjaardagen
            Console.WriteLine("Voor verjaardag:");
            Console.WriteLine(student1);
            Console.WriteLine(student2);

            // Roep Verjaar aan (let op de haakjes!).
            student1.Verjaar();      // +1 jaar
            student2.Verjaar(2);     // +2 jaar

            // Print waarden ná de verjaardagen
            Console.WriteLine();
            Console.WriteLine("Na verjaardag:");
            Console.WriteLine(student1);
            Console.WriteLine(student2);
        }
    }
}
