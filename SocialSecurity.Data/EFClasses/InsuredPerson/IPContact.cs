using SocialSecurity.Data.EFClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data.EFClasses.InsuredPerson
{
    public class IPContact : EntityBase
    {

        [Phone]
        //        [DataType(DataType.PhoneNumber)]
        public string TelephoneNumber1 { get; set; }
        [Phone]
        public string TelephoneNumber2 { get; set; }
        [Phone]
        public string WorkNumber { get; set; }
        [Phone]
        public string MobileNumber1 { get; set; }
        [Phone]
        public string MobileNumber2 { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public long InsuredPersonID { get; set; }
        [ForeignKey("InsuredPersonID")]
        public IPMaster IPMaster { get; set; }

    }
}
