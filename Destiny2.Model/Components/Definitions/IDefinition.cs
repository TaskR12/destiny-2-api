using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public interface IDefinition
    {
        long Hash { get; set; }
        int Index { get; set; }
        bool Redacted { get; set; }
    }
}
