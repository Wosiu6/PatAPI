namespace PatAPI.Infrastructure.Models.HLTB._next
{
    using System.Text.Json.Serialization;

    public class Individuality
    {
        [JsonPropertyName("platform")]
        public string? Platform { get; set; }

        [JsonPropertyName("count_comp")]
        public string? CountComp { get; set; }

        [JsonPropertyName("comp_main")]
        public string? CompMain { get; set; }

        [JsonPropertyName("comp_plus")]
        public string? CompPlus { get; set; }

        [JsonPropertyName("comp_100")]
        public string? Comp100 { get; set; }

        [JsonPropertyName("comp_all")]
        public string? CompAll { get; set; }

        [JsonPropertyName("compare")]
        public string? Compare { get; set; }
    }
}
