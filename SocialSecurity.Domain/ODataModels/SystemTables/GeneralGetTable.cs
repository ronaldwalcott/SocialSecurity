using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Domain.ODataModels.SystemTables
{
    public class GeneralGetTable
    {
        public long ID { get; set; }
        public string Code { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
