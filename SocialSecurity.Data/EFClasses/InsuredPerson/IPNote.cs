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
    public class IPNote : EntityBase
    {
        [StringLength(250)]
        public string Note { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset NoteDate { get; set; }

        public long InsuredPersonID { get; set; }
        [ForeignKey("InsuredPersonID")]
        public IPMaster IPMaster { get; set; }
    }
}
