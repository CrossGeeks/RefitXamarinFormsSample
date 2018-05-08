using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Refit;
using RefitXFSample.Models;

namespace RefitXFSample
{
    [Headers("Content-Type: application/json")]
    public interface IMakeUpApi
    {
        [Get("/api/v1/products.json?brand={brand}")]
        Task<HttpResponseMessage> GetMakeUps(string brand, CancellationToken cancellationToken);

        [Post("/api/v1/addMakeUp")]
        Task<MakeUp> CreateMakeUp([Body] MakeUp makeUp, [Header("Authorization")] string token, CancellationToken cancellationToken);
    }
}
