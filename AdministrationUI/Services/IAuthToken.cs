using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdministrationUI.Services
{
    public interface IAuthToken
    {
        Task<string> GetToken();
    }
}
