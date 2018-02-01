using System;
using Fusillade;

namespace RefitXFSample.Services
{
    public interface IApiService<T>
    {
        T GetApi(Priority priority);

    }
}

