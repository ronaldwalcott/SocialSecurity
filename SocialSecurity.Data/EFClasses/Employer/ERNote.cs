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
    public class ERNote : EntityBase
    {
        [StringLength(250)]
        public string Note { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset NoteDate { get; set; }

        public long ERMasterID { get; set; }
        [ForeignKey("ERMasterID")]
        public ERMaster ERMaster { get; set; }
    }
}
