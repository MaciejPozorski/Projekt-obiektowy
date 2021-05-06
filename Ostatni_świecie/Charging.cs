using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Charging
    {
        
        public static void ChargeBatteries()
        {
             

            bool check = true;
            while (check == true)
            {

                Console.Write("|==========================================|\n");
                Console.Write("| Podaj czas ładowania baterii (Exit = 0): |\n");
                Console.Write("|==========================================|\n");

                try
                {
                    int time = Convert.ToInt32(Console.ReadLine());
                   
                    if(time == 0)
                    {
                        check = false;
                    }
                    else
                    {
                        Stats.Battery += 10 * time;
                        if (Stats.Battery > 100)
                        {
                            Stats.Battery = 100;
                        }                      
                        check = false;
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
