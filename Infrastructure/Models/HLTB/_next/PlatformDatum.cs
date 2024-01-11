namespace PatAPI.Infrastructure.Models.HLTB._next
{
    using System.Text.Json.Serialization;

    public class PlatformDatum
    {
        [JsonPropertyName("platform")]
        public string? Platform { get; set; }

        [JsonPropertyName("count_comp")]
        public int? CountComp { get; set; }

        [JsonPropertyName("count_total")]
        public int? CountTotal { get; set; }

        [JsonPropertyName("comp_main")]
        public int? CompMain { get; set; }

        [JsonPropertyName("comp_plus")]
        public int? CompPlus { get; set; }

        [JsonPropertyName("comp_100")]
        public int? Comp100 { get; set; }

        [JsonPropertyName("comp_low")]
        public int? CompLow { get; set; }

        [JsonPropertyName("comp_high")]
        public int? CompHigh { get; set; }
    }

}
