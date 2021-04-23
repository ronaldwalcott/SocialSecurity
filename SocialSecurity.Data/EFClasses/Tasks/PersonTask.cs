using SocialSecurity.Data.EFClasses.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data.EFClasses.Tasks
{
    public class PersonTask : EntityBase
    {
        [Required]
        public string Title { get; set; }
        [StringLength(50)]
        [Required]
        public string Status { get; set; }
        public string Summary { get; set; }
        [Required]
        [StringLength(50)]
        public string TaskType { get; set; }
        [Required]
        [StringLength(50)]
        public string Priority { get; set; }
        public string ReferenceEntity { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTimeOffset? ReferenceDate { get; set; }
        public DateTimeOffset? DateToBeCompleted { get; set; }
        public string Colour { get; set; }
        public string User { get; set; }
        public string UserID { get; set; }

    }
}
