using SocialSecurity.Data.EFClasses.BaseClasses;
using SocialSecurity.Domain.ODataModels.SystemTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Domain.Actions
{
    public class PutGeneralTableData
    {
        public static void PutData<TEntity>(TEntity entity, GeneralGetTable generalGetTable) where TEntity : TableBaseClass
        {
            entity.Code = generalGetTable.Code;
            entity.ShortDescription = generalGetTable.ShortDescription;
            entity.LongDescription = generalGetTable.LongDescription;
        }

    }
}
