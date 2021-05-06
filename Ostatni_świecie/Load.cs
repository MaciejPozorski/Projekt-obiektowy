using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ostatni_świecie
{

    class Load
    {
        
      
        Menu game = new Menu();
       // Stats stats = new Stats();

        public void LoadSave()
        {
            //Stats stats = new Stats();
            
            int battery;
            int km;
            int strength;
            // int repairCost;
            //  string witchEvent;

            string path = "stats.txt";           
            string[] read = File.ReadAllLines(path); 
            Stats.Battery = Convert.ToInt32(read[0]);
            Stats.Km = Convert.ToInt32(read[1]);
            Stats.Strength = Convert.ToInt32(read[2]);
            //repairCost = Convert.ToInt32(read[3]);
            //  witchEvent = read[4];
            //stats2.battery = battery;
            //Stats stats = stats2;
            
            
        }
    }
}
