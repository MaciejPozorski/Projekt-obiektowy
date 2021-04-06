using System;

namespace Ostatni_świecie
{
    class Menu
    {
        public int batery = 100;
        public int km = 0;
        public bool intro = true;
        public void MainMenu()
        {
            Save sv = new Save();
            int start = 0;
            
            if(intro == true)
            {
                Console.WriteLine("Tu pojawia się otoczka fabularna ;)");
                Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować.");
                Console.ReadKey();
                Console.Clear();
            }

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
                            sv.SaveStats(batery, km);
                            break;
                        case 6:
                            start++;
                            Console.Clear();
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

