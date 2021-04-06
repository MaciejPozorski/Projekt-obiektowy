using System;

namespace Ostatni_świecie
{
    class Menu
    {
        public void MenuGlowne()
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
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        start++;
                        break;
                }
            }
        }
    } 
}

