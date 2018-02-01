using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace RefitXFSample.Services
{
    public interface IApiManager
    {
       Task<HttpResponseMessage> GetMakeUps(string brand);
    }
}
