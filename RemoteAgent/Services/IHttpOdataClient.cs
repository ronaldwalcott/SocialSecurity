using Simple.OData.Client;

namespace RemoteAgent.Services
{
    public interface IHttpOdataClient
    {
        ODataClient GetClient();
    }
}
