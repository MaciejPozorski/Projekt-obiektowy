using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Events
    {
        public void DrawEvent(ref int batery, int draw)
        {
            switch(draw)
            {
                case 1:
                    Console.WriteLine("Event 1");
                    batery -= 10;
                    Console.WriteLine(batery);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
