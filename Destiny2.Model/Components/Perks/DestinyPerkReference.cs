using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Perks
{
    public class DestinyPerkReference
    {
        public long PerkHash { get; set; }
        public string IconPath { get; set; }
        public bool IsActive { get; set; }
        public bool Visible { get; set; }
    }
}
