using SocialSecurity.Data.EFClasses.BaseClasses;
using SocialSecurity.Domain.ODataModels.SystemTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Domain.Actions
{
    public class GetGeneralTableData
    {
        public static void GetData<TEntity>(TEntity entity, GeneralGetTable generalGetTable) where TEntity : TableBaseClass
        {
            generalGetTable.ID = entity.ID;
            generalGetTable.Code = entity.Code;
            generalGetTable.ShortDescription = entity.ShortDescription;
            generalGetTable.LongDescription = entity.LongDescription;
        }
    }
}
