using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RemoteAgent.Services
{
    public interface IHttpClient
    {
        Task<System.Net.Http.HttpClient> GetClient();
    }
}
