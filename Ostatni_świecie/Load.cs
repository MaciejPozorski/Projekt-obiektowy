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
            string path = "stats.txt";           
            string[] read = File.ReadAllLines(path); 
            Stats.Battery = Convert.ToInt32(read[0]);
            Stats.Km = Convert.ToInt32(read[1]);
            Stats.Strength = Convert.ToInt32(read[2]);
            Stats.RepairCost = Convert.ToInt32(read[3]);
              Stats.WitchEvent = (string)read[4];
            //stats2.battery = battery;
            //Stats stats = stats2;
            
            
        }
    }
}
