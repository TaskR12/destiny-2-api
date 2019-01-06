using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions.Records
{
    public class DestinyRecordCompletionBlock
    {
        public int PartialCompletionObjectiveCountThreshold { get; set; }
        public int ScoreValue { get; set; }
        public bool ShouldFireToast { get; set; }
        public EDestinyRecordToastStyle ToastStyle { get; set; }
    }
}
