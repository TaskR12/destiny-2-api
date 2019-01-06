using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using Destiny2.Api.Model.Milestones;

namespace Destiny2.Api.Model.Definitions
{
    public enum EDestinyActivityModeCategory
    {
        None = 0,
        PvE = 1,
        PvP = 2,
        PvECompetitive = 3,
    }


    public class DestinyActivityModeDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public string PgcrImage { get; set; }
        public EActivityModeType ModeType { get; set; }
        public EDestinyActivityModeCategory ActivityModeCategory { get; set; }
        public bool IsTeamBased { get; set; }
        public bool IsAggregateMode { get; set; }
        public IEnumerable<long> ParentHashes { get; set; }
        public string FriendlyName { get; set; }
        public Dictionary<long, EActivityModeType> ActivityModeMappings { get; set; }
        public bool Display { get; set; }
        public int Order { get; set; }
    }
}
