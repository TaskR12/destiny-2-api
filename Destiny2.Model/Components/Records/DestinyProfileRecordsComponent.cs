using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Records
{
    public class DestinyProfileRecordsComponent
    {
        public int Score { get; set; }
        public long TrackedRecordHash {get;set;}
        public Dictionary<long, DestinyRecordComponent> Records { get; set; }
    }
}
