using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Menu
    {
        public static bool intro;

        // obiekty są stworzone statycznie, aby nie tworzyć ciągle niepotrzebnie nowych instancji 
        public static void MainMenu()
        {


            bool start = true;   
            
            if(intro == true)
            {
                Start.AtlasIntro();
                Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować.");
                Console.ReadKey();
                Console.Clear();
            }

            while (start == true)
            {
                
                Console.WriteLine(" Bateria: {0}, Siła: {1} Przebyte km: {2}", Stats.Battery, Stats.Strength, Stats.Km);
                Console.WriteLine("|==============================|");
                Console.WriteLine("|          1. Podróż           |");
                Console.WriteLine("|     2. Ładowanie baterii     |");
                Console.WriteLine("|         3. Warsztat          |");
                Console.WriteLine("|          4. Naprawa          |");
                Console.WriteLine("|          5. Zapisz           |");
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
                           Travel.Traveling();
                            break;
                        case 2:
                            Console.Clear();
                            Charging.ChargeBatteries();
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
                            Save.SaveStats();
                            break;
                        case 0:
                            start = false;
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

