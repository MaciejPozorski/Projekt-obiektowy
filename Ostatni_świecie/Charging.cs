using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Charging
    {
        int battery;
        public void ChargeBatteries()
        {
             
            Stats stats = new Stats();
           // stats.UnloadBattery(battery);
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
                        battery += 10 * time;
                        if (battery > 100)
                        {
                            battery = 100;
                        }
                       // stats.LoadBattery(battery);
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
