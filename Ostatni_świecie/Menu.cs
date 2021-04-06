using System;

namespace Ostatni_świecie
{
    class Menu
    {
        public void MainMenu()
        {
            int start = 0;

            while (start == 0)
            {
                Console.WriteLine("|==============================|");
                Console.WriteLine("|          1. Podróż           |");
                Console.WriteLine("|     2. Ładowanie baterii     |");
                Console.WriteLine("|         3. Warsztat          |");
                Console.WriteLine("|          4. Naprawa          |");
                Console.WriteLine("|          5. Zapisz           |");
                Console.WriteLine("|           6. Wyjdź           |");
                Console.WriteLine("|==============================|");

                Console.WriteLine("Wybierz opcję: ");

                try
                {
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
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
                            break;
                        case 5:
                            Console.Clear();
                            break;
                        case 6:
                            start++;
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

