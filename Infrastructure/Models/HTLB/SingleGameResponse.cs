using System.Text.Json.Serialization;

namespace Infrastructure.Models.HTLB
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class SingleGameResponse
    {
        [JsonPropertyName("game")]
        public List<GameData>? Game { get; set; }

        [JsonPropertyName("individuality")]
        public List<Individuality>? Individuality { get; set; }

        [JsonPropertyName("platformData")]
        public List<PlatformData>? PlatformData { get; set; }

        [JsonPropertyName("relationships")]
        public List<object>? Relationships { get; set; }

        [JsonPropertyName("userReviews")]
        public UserReviews? UserReviews { get; set; }
    }
}
