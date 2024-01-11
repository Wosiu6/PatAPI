namespace PatAPI.Infrastructure.Models.HLTB._next
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Data
    {
        [JsonPropertyName("game")]
        public List<Game>? Game { get; set; }

        [JsonPropertyName("individuality")]
        public List<Individuality>? Individuality { get; set; }

        [JsonPropertyName("relationships")]
        public List<object>? Relationships { get; set; }

        [JsonPropertyName("userReviews")]
        public UserReviews? UserReviews { get; set; }

        [JsonPropertyName("platformData")]
        public List<PlatformDatum>? PlatformData { get; set; }
    }

}
