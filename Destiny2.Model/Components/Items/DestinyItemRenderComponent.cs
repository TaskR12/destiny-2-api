using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Items
{
    public class DestinyItemRenderComponent
    {
        public bool UseCustomDyes { get; set; }
        public Dictionary<int,int> ArtRegions { get; set; }


    }
}
