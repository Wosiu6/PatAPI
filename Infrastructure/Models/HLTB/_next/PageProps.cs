namespace PatAPI.Infrastructure.Models.HLTB._next
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PageProps
    {
        [JsonPropertyName("game")]
        public Game? Game { get; set; }

        [JsonPropertyName("ignWikiSlug")]
        public string? IgnWikiSlug { get; set; }

        [JsonPropertyName("ignMap")]
        public IgnMap? IgnMap { get; set; }

        [JsonPropertyName("ignWikiNav")]
        public List<IgnWikiNav>? IgnWikiNav { get; set; }

        [JsonPropertyName("pageMetadata")]
        public PageMetadata? PageMetadata { get; set; }
    }
}
