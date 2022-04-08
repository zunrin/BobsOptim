using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Plugins;
using Hearthstone_Deck_Tracker.Utility.Logging;
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
        private HelloWorldWindow helloWorldWindow;

        public void OnLoad()
        {
            Log.Info("Loaded bobs optim");
            helloWorldWindow = new HelloWorldWindow();
            Core.OverlayCanvas.Children.Add(helloWorldWindow);

            HelloWorldController hwController = new HelloWorldController(helloWorldWindow);
            GameEvents.OnGameStart.Add(hwController.GameStart);
            GameEvents.OnInMenu.Add(hwController.InMenu);
            GameEvents.OnTurnStart.Add(hwController.TurnStart);
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
