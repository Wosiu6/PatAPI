namespace PatAPI.Infrastructure.Models.HLTB._next
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class IgnMap
    {
        [JsonPropertyName("__typename")]
        public string? Typename { get; set; }

        [JsonPropertyName("mapType")]
        public string? MapType { get; set; }

        [JsonPropertyName("mapName")]
        public string? MapName { get; set; }

        [JsonPropertyName("mapSlug")]
        public string? MapSlug { get; set; }

        [JsonPropertyName("objectSlug")]
        public string? ObjectSlug { get; set; }

        [JsonPropertyName("objectName")]
        public string? ObjectName { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public double? Height { get; set; }

        [JsonPropertyName("minZoom")]
        public int? MinZoom { get; set; }

        [JsonPropertyName("maxZoom")]
        public int? MaxZoom { get; set; }

        [JsonPropertyName("tilesets")]
        public List<string>? Tilesets { get; set; }

        [JsonPropertyName("initialLat")]
        public double? InitialLat { get; set; }

        [JsonPropertyName("initialLng")]
        public double? InitialLng { get; set; }

        [JsonPropertyName("initialZoom")]
        public int? InitialZoom { get; set; }
    }
}
