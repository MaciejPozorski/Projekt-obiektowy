using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Events
    {
        public void DrawEvent(int draw)
        {
            switch(draw)
            {
                case 1:
                    Console.WriteLine("Event 1");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
