using Microsoft.Extensions.Caching.Memory;
using System.Net;

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
            string? gameName = request.Content?.ReadAsStringAsync(cancellationToken).Result;

            string? cached = _cache.Get<Task<string>?>(gameName)?.Result;

            if (cached is not null)
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(cached)
                };
            }

            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);
            Task<string>? content = response.Content.ReadAsStringAsync(cancellationToken);

            await _cache.Set(gameName, content, TimeSpan.FromHours(1));

            return response;
        }
    }
}
