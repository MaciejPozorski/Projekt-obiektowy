using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Charging
    {
        public void ChargeBatteries(ref int batery)
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
                        batery += 10 * time;
                        if (batery > 100)
                        {
                            batery = 100;
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
