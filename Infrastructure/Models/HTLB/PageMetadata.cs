using System.Text.Json.Serialization;

namespace Infrastructure.Models.HTLB
{
    public class PageMetadata
    {
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("canonical")]
        public string? Canonical { get; set; }

        [JsonPropertyName("template")]
        public string? Template { get; set; }
    }
}
