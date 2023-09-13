using System.Text.Json.Serialization;

namespace Infrastructure.Models.HTLB
{
    public class PageProps
    {
        [JsonPropertyName("game")]
        public GameData? Game { get; set; }

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
