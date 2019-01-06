using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions.Records
{
    public class DestinyRecordTitleBlock
    {
        public bool HasTitle { get; set; }
        public Dictionary<EDestinyGender,string> TitlesByGender { get; set; }
        public Dictionary<long,string> TitlesByGenderHash { get; set; }
    }
}
