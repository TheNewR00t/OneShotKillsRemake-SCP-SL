using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotKillRemake
{
    public class Config : IConfig
    {
        [Description("Enable this pls...")]
        public bool IsEnabled { get; set; } = true;
        [Description("Dont enable this pls...")]
        public bool Debug { get; set; } = false;
    }
}
