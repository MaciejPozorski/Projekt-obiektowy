using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Events
    {

        public static void draw()
        {
            Random random = new Random(); //ty będzie losowanie, prace trwają ale działka wzywa, dokończę w ten weekend
            int draw = int.Parse(Console.ReadLine());
            switch (draw)
            {
                case 1:
                    Damage damage1 = new Damage(20, "awaria anteny");
                    break;
            }
            
        }
       class Damage
        {
            public Damage(int repairCost, string witchEvent)
            {
                Stats.RepairCost = repairCost;
                Stats.WitchEvent = witchEvent;
            }
        }
    }
}
