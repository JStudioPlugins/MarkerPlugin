using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steamworks;

namespace MarkerPlugin
{
    public class MarkerPlugin : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log("MarkerPlugin by Jdance has now loaded!");
            UnturnedPlayerEvents.OnPlayerDeath += this.UnturnedPlayerEvents_OnPlayerDeath;
        }

        private void UnturnedPlayerEvents_OnPlayerDeath(Rocket.Unturned.Player.UnturnedPlayer player, SDG.Unturned.EDeathCause cause, SDG.Unturned.ELimb limb, global::Steamworks.CSteamID murderer)
        {
            player.Player.quests.replicateSetMarker(true, player.Position, $"Last Death");
        }

        protected override void Unload()
        {
            Logger.Log("MarkerPlugin does not support unloading!");

        }
    }
}