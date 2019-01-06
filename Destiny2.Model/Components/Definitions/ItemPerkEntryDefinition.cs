using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public enum EPerkVisibility
    {
        Visible = 0,
        Disabled = 1,
        Hidden = 2,
    }

    public class ItemPerkEntryDefinition
    {
        public string RequirementDisplayString { get; set; }
        public long PerkHash { get; set; }
        public EPerkVisibility PerkVisibility { get; set; }

    }
}
