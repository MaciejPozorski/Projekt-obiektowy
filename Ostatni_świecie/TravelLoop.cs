using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class TravelLoop
    {
       
        
        public void tLoop(ref int km, ref int batery, ref int time, ref int repairCost)
        {

            int check = 0;
            Travel travel = new Travel();
            Events events = new Events();
            Menu menu = new Menu();
            while (check <time && repairCost != 0)
            {
                check++;
                events.draw(ref repairCost);
                if (repairCost != 0)
                {
                    km =km+  1000;
                    batery =batery - 10;
                }
                else
                {
                    Console.WriteLine("Awaria!");
                    Console.ReadLine();
                    
                }
            }
        }
        

    }
}
