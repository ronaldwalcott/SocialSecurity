using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data.EFClasses.BaseClasses
{
    public class TableBaseClass : EntityBase
    {
        [StringLength(10)]
        [Required]
        public string Code { get; set; }
        [StringLength(50)]
        [Required]
        public string ShortDescription { get; set; }
        [StringLength(90)]
        [Required]
        public string LongDescription { get; set; }

    }
}
