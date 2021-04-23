using SocialSecurity.Data.EFClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data.EFClasses.InsuredPerson
{
    public class IPSSN : EntityBase
    {
        [StringLength(15)]
        public string SSN { get; set; }
    }
}
