using Hearthstone_Deck_Tracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsOptim
{
    public class HelloWorldController
    {
        private HelloWorldWindow helloWorldWindow;

        public HelloWorldController(HelloWorldWindow helloWorldWindow)
        {
            this.helloWorldWindow = helloWorldWindow;
        }

        internal void GameStart()
        {
            helloWorldWindow.Update("Game Start");
        }

        internal void InMenu()
        {
            helloWorldWindow.Update("In Menu");
        }

        internal void TurnStart(ActivePlayer player)
        {
            switch (player)
            {
                case ActivePlayer.Opponent:
                    helloWorldWindow.Update("opponent");
                    break;
                case ActivePlayer.Player:
                    helloWorldWindow.Update("player");
                    break;

            }
        }
    }
}
