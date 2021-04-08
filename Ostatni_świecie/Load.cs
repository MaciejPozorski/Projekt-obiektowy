using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ostatni_świecie
{
    class Load
    {
        public void LoadStats()
        {
            Menu game = new Menu();
            string path = "stats.txt";           
            string[] read = File.ReadAllLines(path);
            game.batery = Convert.ToInt32(read[0]);
            game.km = Convert.ToInt32(read[1]);
            Console.WriteLine(game.batery);    
            Console.WriteLine(game.km);
        }
    }
}
