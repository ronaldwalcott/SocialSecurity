using SocialSecurity.Data.EFClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data.EFClasses.Employer
{
    public class ERContact : EntityBase
    {
        [Phone]
        public string MainTelephoneNumber { get; set; }
        [Phone]
        public string SecondaryTelephoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Url]
        public string WebAddress { get; set; }

        public long ERMasterID { get; set; }
        [ForeignKey("ERMasterID")]
        public ERMaster ERMaster { get; set; }

    }
}
