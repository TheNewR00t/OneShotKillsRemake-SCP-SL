using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OneShotKillRemake
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public void OnHeart(HurtingEventArgs ev)
        {
            if (ev.Attacker == null) { return; }

            if (ev.Attacker.Role.Type == RoleTypeId.Scp106) 
            {
                ev.Player.EnableEffect($"{EffectType.PocketCorroding.ToString()}");
            }

            if (ev.Attacker.Role.Type == RoleTypeId.Scp049)
            {
                ev.Player.Kill("Killed by SCP-049");
            }
            
        }

    }
}
