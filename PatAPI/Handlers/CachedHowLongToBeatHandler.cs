using Microsoft.Extensions.Caching.Memory;
using System.Collections.Specialized;
using System.Net;
using System.Web;

namespace PatAPI.Handlers
{
    public class CachedHowLongToBeatHandler : DelegatingHandler
    {
        private readonly IMemoryCache _cache;

        public CachedHowLongToBeatHandler(IMemoryCache cache)
        {
            _cache = cache;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //TODO write a separate handler for each HLTB action to make this cleaner (if the need arises)
            string key = GetCacheKey(request);

            if (_cache.TryGetValue(key, out Task<string>? cachedContent) && cachedContent != null)
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(await cachedContent)
                };
            }

            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                Task<string> content = response.Content.ReadAsStringAsync(cancellationToken);
                await _cache.Set(key, content, TimeSpan.FromHours(1));
            }

            return response;
        }

        private static string GetCacheKey(HttpRequestMessage request)
        {
            if (request.Content != null)
            {
                return request.Content.ReadAsStringAsync().Result;
            }

            var query = HttpUtility.ParseQueryString(request.RequestUri?.Query ?? "");
            return query["gameId"] ?? "buildId";
        }
    }
}
