using SocialSecurity.Data.EFClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data.EFClasses.InsuredPerson
{
    public class IPMaster : EntityBase
    {
        //[StringLength(15)]
        //public string SSN { get; set; }
        [StringLength(70)]
        [Required]
        public string Surname { get; set; }
        [StringLength(70)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(70)]
        public string MiddleName { get; set; }
        [StringLength(70)]
        public string OtherName { get; set; }
        [StringLength(70)]
        public string MaidenName { get; set; }

        public IPSSN IPSSN { get; set; }
        public IPAddress IPAddress { get; set; }
        public IPBasic IPBasic { get; set; }
        public IPContact IPContact { get; set; }
        public ICollection<IPRegEmployer> IPRegEmployers { get; set; }
        public ICollection<IPRegistrationDocument> IPRegistrationDocuments { get; set; }
        public IPSpouse IPSpouse { get; set; }

        public DateTimeOffset? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }

    }
}
