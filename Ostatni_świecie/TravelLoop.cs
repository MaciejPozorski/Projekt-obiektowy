using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class TravelLoop
    {
       
        
        public void tLoop(ref int km, ref int batery, ref int time)
        {

            bool repairCheck=false;
            int check = 0;
            Travel travel = new Travel();
            Events events = new Events();
            Menu menu = new Menu();
            while (check <time)
            {
                check++;
                events.draw(ref repairCheck);
                if (repairCheck==false)
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
