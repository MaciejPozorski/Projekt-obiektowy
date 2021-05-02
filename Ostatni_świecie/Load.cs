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

        public void LoadStats()
        {
            Stats stats = new Stats();
                int battery;
            int km;
            int strength;
            // int repairCost;
            //  string witchEvent;

            string path = "stats.txt";           
            string[] read = File.ReadAllLines(path); 
            battery = Convert.ToInt32(read[0]);
            km = Convert.ToInt32(read[1]);
            strength = Convert.ToInt32(read[2]);
            //repairCost = Convert.ToInt32(read[3]);
          //  witchEvent = read[4];
stats.LoadAll(ref battery,ref  km,ref strength);
            Console.WriteLine(stats.battery);
            Console.WriteLine(stats.km);
            Console.ReadLine();
        }
    }
}
