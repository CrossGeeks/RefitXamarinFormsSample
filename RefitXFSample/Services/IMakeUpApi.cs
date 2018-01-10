using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using RefitXFSample.Models;

namespace RefitXFSample
{
    [Headers("Content-Type: application/json")]
    public interface IMakeUpApi
    {
        [Get("/api/v1/products.json?brand={brand}")]
        Task<List<MakeUp>> GetMakeUps(string brand);

        [Post("/api/v1/addMakeUp")]
        Task<MakeUp> CreateMakeUp([Body] MakeUp makeUp, [Header("Authorization")] string token);
    }
}
