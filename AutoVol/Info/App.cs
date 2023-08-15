using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVol.Info
{
    public class App
    {
        public int VolumePercentage { get;  set; }
        public string Name { get;  set; }
        private App(string name,int volumePercentage)
        {
            VolumePercentage = volumePercentage;
            Name = name;
        }
        public App() { }
        public static App? Create(string name, int volumePercentage)
        {
            if (volumePercentage >= 0 && volumePercentage <= 100)
            {
                App app = new(name, volumePercentage);
                return app;
            }
            return null;
        }
        public override string ToString()
        {
            return Name + " Vol: " + VolumePercentage;
        }
    }
}
