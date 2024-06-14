using ExiledhandlerP = Exiled.Events.Handlers.Player;
using Exiled.API.Features;
using System;

namespace OneShotKillRemake
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "OneShotKillsRemake";
        public override string Author => "@misfiy - Remake by Davilone32";

        private EventHandlers Handlers;
        public override void OnEnabled()
        {
            Handlers = new EventHandlers(this);
            ExiledhandlerP.Hurting += Handlers.OnHeart;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            ExiledhandlerP.Hurting -= Handlers.OnHeart;
            Handlers = null;
            base.OnDisabled();
        }
    }
}
