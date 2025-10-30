namespace forif;

class Program
{
    static void Main(string[] args)
    {
        int[] nultotnegen = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      foreach (int item in nultotnegen)
        {
            if (item >= 3 && item <= 7)
            {
                Console.WriteLine(item);
            }
        }
    }
}
