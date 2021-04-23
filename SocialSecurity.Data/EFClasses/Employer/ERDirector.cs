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
    public class ERDirector : EntityBase
    {


        [StringLength(70)]
        [Required]
        public string Surname { get; set; }
        [StringLength(70)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(70)]
        public string MiddleName { get; set; }
        public bool ManagingDirector { get; set; }

        public long ERMasterID { get; set; }
        [ForeignKey("ERMasterID")]
        public ERMaster ERMaster { get; set; }

    }
}
