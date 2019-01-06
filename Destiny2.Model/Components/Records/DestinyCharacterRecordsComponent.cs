using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Records
{
    public class DestinyCharacterRecordsComponent
    {
        public long FeaturedRecordHashes { get; set; }
        public Dictionary<long,DestinyRecordComponent> Records { get; set; }
    }
}
