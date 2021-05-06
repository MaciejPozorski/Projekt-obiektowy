using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class TravelLoop
    {
       
        
        public static void tLoop(ref int time)
        {

            int check = 0;
            while (check <time &&  Stats.RepairCost == 0)
            {
                check++;
                Events.draw();
                if (Stats.RepairCost == 0)
                {
                    Stats.Km +=  1000;
                    Stats.Battery -= 10;
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
