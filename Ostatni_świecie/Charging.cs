using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Charging
    {
        
        public static void ChargeBatteries()
        {             

            bool start = true;
                if (Stats.RepairCost>=50)
                {
                    Console.WriteLine("Brak mocy! Nie możesz naładować baterii.");
                    Console.WriteLine(Stats.WitchEvent);
                    Console.ReadLine();
                    Console.Clear();
                    start = false;                   
                }
            while (start == true)
            {


                Console.Write("|==========================================|\n");
                Console.Write("| Podaj czas ładowania baterii (Exit = 0): |\n");
                Console.Write("|==========================================|\n");

                try
                {
                    int time = Convert.ToInt32(Console.ReadLine());
                   
                    if(time == 0)
                    {
                        start = false;
                    }
                    else
                    {
                        Stats.Battery += 10 * time;
                        if (Stats.Battery > 150)
                        {
                            Stats.Battery = 150;
                        }                      
                        start = false;
                    }
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Tak to się nie uda! Podaj ile godzin.");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }
            
            

        }
    }
}
