using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemoteAgent.Services
{
    public interface IAuthToken
    {
        Task<string> GetToken();
    }
}
