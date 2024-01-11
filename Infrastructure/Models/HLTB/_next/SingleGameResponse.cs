namespace PatAPI.Infrastructure.Models.HLTB._next
{
    using System.Text.Json.Serialization;

    public class SingleGameResponse
    {
        [JsonPropertyName("pageProps")]
        public PageProps? PageProps { get; set; }

        [JsonPropertyName("__N_SSP")]
        public bool? NSSP { get; set; }
    }
}
