using SocialSecurity.Domain.ODataModels.SystemTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialSecurity.Data.EFClasses.BaseClasses;
using SocialSecurity.Domain.Constants;

namespace SocialSecurity.Domain.Actions
{
    public class PostGeneralTableData 
    {
        public static void PostData<TEntity> (TEntity entity, GeneralPostTable generalPostTable) where TEntity : TableBaseClass
        {
            entity.Code = generalPostTable.Code;
            entity.ShortDescription = generalPostTable.ShortDescription;
            entity.LongDescription = generalPostTable.LongDescription;
        }
    }
}
