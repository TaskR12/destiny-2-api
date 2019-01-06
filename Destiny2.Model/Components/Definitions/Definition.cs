using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class Definition : IDefinition
    {
        public long Hash { get; set; }
        public int Index { get; set; }
        public bool Redacted { get; set; }
    }
}
