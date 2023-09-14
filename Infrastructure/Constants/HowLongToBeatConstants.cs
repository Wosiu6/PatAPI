namespace Infrastructure.Constants
{
    public static class HowLongToBeatConstants
    {
        public const string ClientName = "howLongToBeatClient";

        public const string UserAgent = "Chrome";
        public const string ContentType = "applcation/json";
        public static readonly Uri BaseUrl = new("https://howlongtobeat.com/");
        public const string ApiSearchPath = "api/search";
        public const string ApiSingleGameFormattablePath = "_next/data/ZvTj64XbXtcJfXptCYRJw/game/{0}.json?gameId={0}";
    }
}
