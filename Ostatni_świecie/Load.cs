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
            string path = "stats.txt";
            Menu game = new Menu();
            string[] read = File.ReadAllLines(path);
            game.batery = Convert.ToInt32(read[0]);
            game.km = Convert.ToInt32(read[1]);
            Console.WriteLine(game.km);
            Console.WriteLine(game.batery);
            
        }
    }
}
