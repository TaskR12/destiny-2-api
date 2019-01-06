using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyObjectiveDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public int CompletionValue { get; set; }
        public EDestinyGatingScope Scope { get; set; }
        public long LocationHash { get; set; }
        public bool AllowNegativeValue { get; set; }
        public bool AllowValueChangeWhenCompleted { get; set; }
        public bool IsCountingDownward { get; set; }
        public EDestinyUnlockValueUIStyle ValueStyle { get; set; }
        public string ProgressDescription { get; set; }
        public DestinyObjectivePerkEntryDefinition Perks { get; set; }
        public DestinyObjectiveStatEntryDefinition Stats { get; set; }
        public int MinimumVisibilityThreshold { get; set; }
        public bool AllowOvercompletion { get; set; }
        public bool ShowValueOnComplete { get; set; }
        public EDestinyUnlockValueUIStyle CompletedValueStyle { get; set; }
        public EDestinyUnlockValueUIStyle InProgressValueStyle { get; set; }
    }
}
