using Microsoft.Extensions.Caching.Memory;
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

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string? key = request.Content?.ReadAsStringAsync(cancellationToken).Result;

            if (key is null)
            {
                var query = HttpUtility.ParseQueryString(request.RequestUri!.Query);

                key = query["gameId"] ?? "buildId";
            }

            string? cached = _cache.Get<Task<string>?>(key)?.Result;

            if (cached is not null)
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(cached)
                };
            }

            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
            Task<string>? content = response.Content.ReadAsStringAsync(cancellationToken);

            await _cache.Set(key, content, TimeSpan.FromHours(1));

            return response;
        }
    }
}
