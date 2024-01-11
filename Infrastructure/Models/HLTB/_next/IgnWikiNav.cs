namespace PatAPI.Infrastructure.Models.HLTB._next
{
    using System.Text.Json.Serialization;

    public class IgnWikiNav
    {
        [JsonPropertyName("__typename")]
        public string? Typename { get; set; }

        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
