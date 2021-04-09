using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Events
    {
        public void DrawEvent(ref int batery, int draw, ref bool repair, ref int repair_cost)
        {
            switch(draw)
            {
                case 1:
                    Console.WriteLine("Event 1");
                    batery -= 10;
                    repair = true;
                    repair_cost = 10;
                    Console.WriteLine(batery);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
