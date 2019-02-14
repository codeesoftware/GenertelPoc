using GenertelPoc.Common.Caches;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GenertelPoc.Infrastructure.Behaviours
{
    class CacheBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        const string CacheName = "cache";
        private readonly IMemoryCache memoryCache;

        public CacheBehaviour(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {

            string key = typeof(TRequest).FullName;
            bool cacheable = request is ICached;
            if (cacheable)
            {
                Dictionary<string, string> preCache = memoryCache.Get<Dictionary<string, string>>(CacheName) ?? new Dictionary<string, string>();
                if (preCache.ContainsKey(key))
                {
                    return JsonConvert.DeserializeObject<TResponse>(preCache[key]);
                }
            }

            TResponse response = await next();

            if (cacheable)
            {
                Dictionary<string, string> postCache = memoryCache.Get<Dictionary<string, string>>(CacheName) ?? new Dictionary<string, string>();
                postCache[key] = JsonConvert.SerializeObject(response);
                memoryCache.Set(CacheName, postCache);
            }
            return response;

        }


    }
}
