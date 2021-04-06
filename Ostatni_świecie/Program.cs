using System;

namespace Ostatni_świecie
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;

            while (start == 0)
            {
                Console.WriteLine("|==============================|");
                Console.WriteLine("|         1. Nowa gra          |");
                Console.WriteLine("|        2. Wczytaj grę        |");
                Console.WriteLine("|    3. Zasady i informacje    |");
                Console.WriteLine("|          4. Autorzy          |");
                Console.WriteLine("|           5. Wyjdź           |");
                Console.WriteLine("|==============================|");

                Console.WriteLine("Wybierz opcję: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("|==============================|");
                        Console.WriteLine("|       Maciej Pozorski        |");
                        Console.WriteLine("|     Przemysław Szymański     |");
                        Console.WriteLine("|==============================|");
                        Console.WriteLine("Wciśnij dowolny przycisk, aby wrócić do menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        start++;
                        break;
                }
            }
        }
    }
}

