namespace PatAPI.Infrastructure.Constants
{
    public static class HowLongToBeatConstants
    {
        public const string ClientName = "howLongToBeatClient";

        public const string UserAgent = "Chrome";
        public const string ContentType = "applcation/json";
        public static readonly Uri BaseUrl = new("https://howlongtobeat.com/");
        public const string ApiSearchPath = "api/search";
        public const string ApiSingleGameFormattablePath = "_next/data/{0}/game/{1}.json?gameId={1}";
    }
}
