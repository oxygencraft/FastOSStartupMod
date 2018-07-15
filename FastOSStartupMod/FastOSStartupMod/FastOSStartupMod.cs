using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pathfinder.ModManager;

namespace FastOSStartupMod
{
    public class FastOSStartupMod : IMod
    {
        public void Load()
        {
            Console.WriteLine("Fast OS Startup Enabled");
        }

        public void LoadContent()
        {
            Hacknet.Settings.slowOSStartup = false;
            Hacknet.Settings.osStartsWithTutorial = false;
        }

        public void Unload()
        {
            Console.WriteLine("Fast OS Startup Disabled");
        }

        public string Identifier{ get { return "FastOSStartupMod"; } }
    }
}
