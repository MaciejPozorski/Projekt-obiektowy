using System;
using System.Collections.Generic;
using System.Text;

namespace Ostatni_świecie
{
    class Stats
    {
        int battery = 100;
        int km = 0;
        int strength = 100;
        int repairCost = 0;
        string witchEvent;
        //ZAŁADUJ
        public void LoadBattery(int bt)
        {
            battery = bt;
        }
        public void LoadKm(int k)
        {
            km = k;
        }     
        public void LoadStrenght(int st)
        {
            strength = st;
        }
        public void LoadRCost(int rc)
        {
            repairCost = rc;
        }
        public void LoadWEvent(string we)
        {
            witchEvent = we;
        }
        public void LoadAll(int bt, int k,int st)
        {
            battery = bt;
            km = k;
            strength = st;
        }
        public void LoadAll(int rc, string we)
        {
            repairCost = rc;
            witchEvent = we;
        }
        public void LoadAll(int bt, int k, int st, int rc, string we)
        {
            battery = bt;
            km = k;
            strength = st;
            repairCost = rc;
            witchEvent = we;
        }

        //WYŁADUJ

        public void UnloadBattery(int bt)
        {
            bt=battery;
        }
        public void UnloadKm(int k)
        {
            k=km;
        }
        public void UnloadStrenght(int st)
        {
            st=strength;
        }
        public void UnloadRCost(int rc)
        {
            rc=repairCost;
        }
        public void UnloadWEvent(string we)
        {
            we=witchEvent;
        }
        public void UnloadAll(int bt, int k, int st)
        {
            bt = battery;
            k = km; ;
            st = strength;
        }
        public void UnloadAll(int rc, string we)
        {
            rc = repairCost;
            we = witchEvent;
        }
        public void UnloadAll(int bt, int k, int st, int rc, string we)
        {
            bt = battery;
            k = km; ;
            st = strength; ;
            rc = repairCost;
            we = witchEvent;
        }

    }
}
