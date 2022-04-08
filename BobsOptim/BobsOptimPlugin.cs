using Hearthstone_Deck_Tracker.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BobsOptim
{
    public class BobsOptimPlugin : IPlugin
    {
        public void OnLoad()
        {
            // Triggered upon startup and when the user ticks the plugin on
        }

        public void OnUnload()
        {
            // Triggered when the user unticks the plugin, however, HDT does not completely unload the plugin.
            // see https://git.io/vxEcH
        }

        public void OnButtonPress()
        {
            // Triggered when the user clicks your button in the plugin list
        }

        public void OnUpdate()
        {
            // called every ~100ms
        }

        public string Name => "Bob's Optim";

        public string Description => "DESCRIPTION";

        public string ButtonText => "BUTTON TEXT";

        public string Author => "AUTHOR";

        public Version Version => new Version(0, 0, 1);

        public MenuItem MenuItem => null;
    }
}
