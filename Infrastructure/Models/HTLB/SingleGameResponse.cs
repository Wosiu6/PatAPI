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

    public class Root
    {
        [JsonPropertyName("pageProps")]
        public PageProps? PageProps { get; set; }

        [JsonPropertyName("__N_SSP")]
        public bool? NSSP { get; set; }
    }

    public class UserReviews
    {
        [JsonPropertyName("5")]
        public object? _5 { get; set; }

        [JsonPropertyName("10")]
        public string? _10 { get; set; }

        [JsonPropertyName("15")]
        public object? _15 { get; set; }

        [JsonPropertyName("20")]
        public string? _20 { get; set; }

        [JsonPropertyName("25")]
        public object? _25 { get; set; }

        [JsonPropertyName("30")]
        public string? _30 { get; set; }

        [JsonPropertyName("35")]
        public object? _35 { get; set; }

        [JsonPropertyName("40")]
        public string? _40 { get; set; }

        [JsonPropertyName("45")]
        public object? _45 { get; set; }

        [JsonPropertyName("50")]
        public object? _50 { get; set; }

        [JsonPropertyName("55")]
        public object? _55 { get; set; }

        [JsonPropertyName("60")]
        public string? _60 { get; set; }

        [JsonPropertyName("65")]
        public object? _65 { get; set; }

        [JsonPropertyName("70")]
        public string? _70 { get; set; }

        [JsonPropertyName("75")]
        public string?   _75 { get; set; }

        [JsonPropertyName("80")]
        public string? _80 { get; set; }

        [JsonPropertyName("85")]
        public string? _85 { get; set; }

        [JsonPropertyName("90")]
        public string? _90 { get; set; }

        [JsonPropertyName("95")]
        public string? _95 { get; set; }

        [JsonPropertyName("100")]
        public string? _100 { get; set; }

        [JsonPropertyName("review_count")]
        public int? ReviewCount { get; set; }
    }
}
