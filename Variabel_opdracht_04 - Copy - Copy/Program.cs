namespace Variabel_opdracht_02;

class Program
{
    static void Main(string[] args)
    {
        string menu = "4 stacked cheese burger, 14 number 9's, 21 liters of a sweatshops tears, 21 liters of my own tears";
        int price4all = 200;
        double priceperitem = price4all / 4.0 * 1.21 * 200 * 2009 - 80 / 40 + 14;
        bool stock = false;
        string availability = stock ? "in stock" : "out of stock";
        string alloftheabove = "menu: " + menu + ", price for all: " + price4all + ", price per item: " + priceperitem + ", availability: " + availability;
        Console.WriteLine(alloftheabove);
    }
}
