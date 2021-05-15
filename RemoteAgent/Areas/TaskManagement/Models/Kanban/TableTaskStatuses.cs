using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAgent.Areas.Appointments.Models.Kanban
{
    public class TableTaskStatuses
    {
        public long ID { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
