using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using RefitXFSample.Models;

namespace RefitXFSample
{
    [Headers("Content-Type: application/json")]
    public interface IRedditApi
    {
        [Get("/subreddit/new.json?sort=top&limit=20")]
        Task<HttpResponseMessage> GetNews();
    }
}
