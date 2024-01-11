using System.Text.Json.Serialization;

namespace PatAPI.Infrastructure.Models.HLTB
{
    public class GameSearchResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("game_id")]
        public int GameId { get; set; }

        [JsonPropertyName("game_name_date")]
        public int GameNameDate { get; set; }

        [JsonPropertyName("comp_lvl_combine")]
        public int CompetitiveLevelCombine { get; set; }

        [JsonPropertyName("comp_lvl_sp")]
        public int CompetitiveLevelSinglePlayer { get; set; }

        [JsonPropertyName("comp_lvl_co")]
        public int CompetitiveLevelCooperative { get; set; }

        [JsonPropertyName("comp_lvl_mp")]
        public int CompetitiveLevelMultiplayer { get; set; }

        [JsonPropertyName("comp_lvl_spd")]
        public int CompetitiveLevelSpeed { get; set; }

        [JsonPropertyName("comp_main")]
        public int CompetitiveMain { get; set; }

        [JsonPropertyName("comp_plus")]
        public int CompetitivePlus { get; set; }

        [JsonPropertyName("comp_100")]
        public int Competitive100 { get; set; }

        [JsonPropertyName("comp_all")]
        public int CompetitiveAll { get; set; }

        [JsonPropertyName("comp_main_count")]
        public int CompetitiveMainCount { get; set; }

        [JsonPropertyName("comp_plus_count")]
        public int CompetitivePlusCount { get; set; }

        [JsonPropertyName("comp_100_count")]
        public int Competitive100Count { get; set; }

        [JsonPropertyName("comp_all_count")]
        public int CompetitiveAllCount { get; set; }

        [JsonPropertyName("invested_co")]
        public int InvestedCo { get; set; }

        [JsonPropertyName("invested_mp")]
        public int InvestedMultiplayer { get; set; }

        [JsonPropertyName("invested_co_count")]
        public int InvestedCoCount { get; set; }

        [JsonPropertyName("invested_mp_count")]
        public int InvestedMultiplayerCount { get; set; }

        [JsonPropertyName("count_comp")]
        public int CompetitiveCount { get; set; }

        [JsonPropertyName("count_speedrun")]
        public int SpeedrunCount { get; set; }

        [JsonPropertyName("count_backlog")]
        public int BacklogCount { get; set; }

        [JsonPropertyName("count_review")]
        public int ReviewCount { get; set; }

        [JsonPropertyName("review_score")]
        public int ReviewScore { get; set; }

        [JsonPropertyName("count_playing")]
        public int PlayingCount { get; set; }

        [JsonPropertyName("count_retired")]
        public int RetiredCount { get; set; }

        [JsonPropertyName("profile_popular")]
        public int ProfilePopular { get; set; }

        [JsonPropertyName("profile_steam")]
        public int ProfileSteam { get; set; }

        [JsonPropertyName("release_world")]
        public int WorldRelease { get; set; }

        [JsonPropertyName("profile_dev")]
        public string? DeveloperProfile { get; set; }

        [JsonPropertyName("profile_platform")]
        public string? PlatformProfile { get; set; }

        [JsonPropertyName("game_name")]
        public string? GameName { get; set; }

        [JsonPropertyName("game_alias")]
        public string? GameAlias { get; set; }

        [JsonPropertyName("game_type")]
        public string? GameType { get; set; }

        [JsonPropertyName("game_image")]
        public string? GameImage { get; set; }
    }

    public class GamesSearchResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("pageCurrent")]
        public int PageCurrent { get; set; }

        [JsonPropertyName("pageTotal")]
        public int PageTotal { get; set; }

        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }

        [JsonPropertyName("color")]
        public string? Color { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("category")]
        public string? Category { get; set; }

        [JsonPropertyName("data")]
        public List<GameSearchResponse>? GameSearchResponse { get; set; }

        [JsonPropertyName("userData")]
        public List<object>? UserData { get; set; }

        [JsonPropertyName("displayModifier")]
        public object? DisplayModifier { get; set; }
    }
}
