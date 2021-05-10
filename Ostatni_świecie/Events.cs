using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Events
    {

        public static void Draw()
        {
            Random random = new Random(); //ty będzie losowanie, prace trwają ale działka wzywa, dokończę w ten weekend
            int draw = random.Next(1, 41);
            switch (draw)
            {
                case 7:                   
                    Damage damage1 = new Damage(10, "Uszkodzona antena radia.");
                    break;
                case 8:
                    Damage damage2 = new Damage(20, "Zerwana antena sonaru.");
                    break;
                case 3:
                    Damage damage3 = new Damage(30, "Uszkodzone poszycie na dziobie statku.");
                    break;
                case 4:
                    Damage damage4 = new Damage(40, "Brak sygnału z radaru. ");
                    break;
                case 5:
                    Damage damage5 = new Damage(50, "Uwaga! Utrata mocy! Generator uszkodzony, silniki są wyłączone.");
                    break;
                case 6:
                    Damage damage6 = new Damage(60, "Uwaga! Silnik uległ awarii! Uruchomienie trybu awaryjnego!");
                    break;
                case 9:
                    Damage damage7 = new Damage(30, "Naruszenie szkieletu kadłuba statku.");
                    break;
                case 10:
                    Damage damage8 = new Damage(20, "Uszkodzenie poszycia w sródokręciu statku.");
                    break;

            }
            
        }
       class Damage
        {
            public Damage(int repairCost, string witchEvent)
            {
                Stats.RepairCost = repairCost;
                Stats.WitchEvent = witchEvent;
                Stats.Strength -= Stats.RepairCost;
            }
        }
    }
}
