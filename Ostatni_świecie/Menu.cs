using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Menu
    {
        public int batery = 0;
        public int km = 0;
        public bool intro = true;
        public bool repair = false;
        public int repair_cost = 0;

        public void MainMenu()
        {
            Travel travel = new Travel();
            Save sv = new Save();
            Charging ch = new Charging();
            Start st = new Start();
            bool start = true;
            
            if(intro == true)
            {
                st.AtlasIntro();
                Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować.");
                Console.ReadKey();
                Console.Clear();
            }

            while (start == true)
            {
                Console.WriteLine(" Bateria: {0}, Przebyte km: {1}",batery, km);
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
                            travel.Traveling(ref batery, ref km, ref repair, ref repair_cost);
                            break;
                        case 2:
                            Console.Clear();
                            ch.ChargeBatteries(ref batery);
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
                            sv.SaveStats();
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

