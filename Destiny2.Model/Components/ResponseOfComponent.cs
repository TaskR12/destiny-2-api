using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model
{
    public enum EComponentPrivacySettings {
        None = 0,
        Public = 1,
        Private = 2,
    }

    public class ResponseOfComponent<T>
    {
        public T Data { get; set; }

        public EComponentPrivacySettings Privacy { get; set; }


    }
}
