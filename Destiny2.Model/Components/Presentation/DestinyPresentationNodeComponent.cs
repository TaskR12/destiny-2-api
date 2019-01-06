using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Quests;

namespace Destiny2.Api.Model.Presentation
{

    public enum EDestinyPresentationNodeState
    {
        None = 0,
        Invisible = 1,
        Obscured = 2,
    }

    public class DestinyPresentationNodeComponent
    {
        public EDestinyPresentationNodeState State { get; set; }
        public DestinyObjectiveProgress Objective { get; set; }
        public int ProgressValue { get; set; }
        public int CompletionValue { get; set; }
    }
}
