using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSecurityAPI.Helpers
{
    public class LoggingErrorText
    {
        public const string recordAlreadyDefined = "This record is probably already defined, please try again";
        public const string errorWithValues = "There is an error with these values";
        public const string recordChanged = "Record has been changed since it was retrieved for editing, please retrieve the new record for editing";
        public const string errorSavingTableData = "Errors generated trying to save table data {tableData} by {username} {errorMessage}";
    }
}
