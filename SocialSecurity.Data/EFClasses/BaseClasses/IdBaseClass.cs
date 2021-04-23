using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data.EFClasses.BaseClasses
{
    public abstract class IdBaseClass<TIdentity>
    {
        public TIdentity ID { get; set; }
    }
}
