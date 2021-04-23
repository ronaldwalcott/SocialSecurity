using SocialSecurity.Data.EFClasses.BaseClasses;
using SocialSecurity.Data.EFClasses.SystemTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Data.EFClasses.InsuredPerson
{
    public class IPRegistrationDocument : EntityBase
    {

        public long? DocumentTypeId { get; set; }
        public TableDocumentType DocumentType { get; set; }
        public long InsuredPersonID { get; set; }
        [ForeignKey("InsuredPersonID")]
        public IPMaster IPMaster { get; set; }

    }
}
