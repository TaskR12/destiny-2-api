using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Items;

namespace Destiny2.Api.Model
{
    public class DestinyItemComponentSetOfint64
    {
        public ResponseOfComponent<Dictionary<long, DestinyItemInstanceComponent>> Instances { get; set; }
        public ResponseOfComponent<Dictionary<long, DestinyItemPerksComponent>> Perks { get; set; }
        public ResponseOfComponent<Dictionary<long, DestinyItemRenderComponent>> RenderData { get; set; }
        public ResponseOfComponent<Dictionary<long, DestinyItemStatsComponent>> Stats { get; set; }
        public ResponseOfComponent<Dictionary<long, DestinyItemSocketsComponent>> Sockets { get; set; }
        public ResponseOfComponent<Dictionary<long, DestinyItemTalentGridComponent>> TalentGrids { get; set; }
        public ResponseOfComponent<Dictionary<long, DestinyItemPlugComponent>> PlugStates { get; set; }
        public ResponseOfComponent<Dictionary<long, DestinyItemObjectivesComponent>> Objectives { get; set; }
    }
}
