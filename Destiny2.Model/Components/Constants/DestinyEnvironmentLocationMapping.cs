using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Constants
{
    public class DestinyEnvironmentLocationMapping
    {
        public long LocationHash { get; set; }
        public string ActivationSource { get; set; }
        public long? ItemHash { get; set; }
        public long? ObjectiveHash { get; set; }
        public long? ActivityHash { get; set; }
    }
}
