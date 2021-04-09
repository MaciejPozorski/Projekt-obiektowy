using System;
using System.IO;

namespace Ostatni_świecie
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu game = new Menu();
            Load ld = new Load();

            bool start = true;

            while (start == true)
            {
                Console.WriteLine("|==============================|");
                Console.WriteLine("|         1. Nowa gra          |");
                Console.WriteLine("|        2. Wczytaj grę        |");
                Console.WriteLine("|    3. Zasady i informacje    |");
                Console.WriteLine("|          4. Autorzy          |");
                Console.WriteLine("|           0. Wyjdź           |");
                Console.WriteLine("|==============================|");
                
                Console.WriteLine("Wybierz opcję: ");

                try
                {
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            game.intro = true;
                            game.MainMenu();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            game.intro = false;
                            ld.LoadStats(ref game.batery, ref game.km);                         
                            game.MainMenu();
                            
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("|   Tu kiedyś będą zasady ;)   |");
                            Console.WriteLine("|                              |");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("Wciśnij dowolny przycisk, aby wrócić do menu.");
                            Console.ReadKey();
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
                        case 0:
                            start = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Nie ma takiej opcji! Wciśnij dowolny przycisk i spróbuj ponownie.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Nieznane polecenie! Wciśnij dowolny przycisk i spróbuj ponownie.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}

