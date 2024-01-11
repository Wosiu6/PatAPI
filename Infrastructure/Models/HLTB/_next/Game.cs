namespace PatAPI.Infrastructure.Models.HLTB._next
{
    using System.Text.Json.Serialization;

    public class Game
    {
        [JsonPropertyName("count")]
        public int? Count { get; set; }

        [JsonPropertyName("data")]
        public Data? Data { get; set; }

        [JsonPropertyName("count_discussion")]
        public int? CountDiscussion { get; set; }

        [JsonPropertyName("game_id")]
        public int? GameId { get; set; }

        [JsonPropertyName("game_name")]
        public string? GameName { get; set; }

        [JsonPropertyName("game_name_date")]
        public int? GameNameDate { get; set; }

        [JsonPropertyName("count_playing")]
        public int? CountPlaying { get; set; }

        [JsonPropertyName("count_backlog")]
        public int? CountBacklog { get; set; }

        [JsonPropertyName("count_replay")]
        public int? CountReplay { get; set; }

        [JsonPropertyName("count_custom")]
        public int? CountCustom { get; set; }

        [JsonPropertyName("count_comp")]
        public int? CountComp { get; set; }

        [JsonPropertyName("count_retired")]
        public int? CountRetired { get; set; }

        [JsonPropertyName("count_review")]
        public int? CountReview { get; set; }

        [JsonPropertyName("review_score")]
        public int? ReviewScore { get; set; }

        [JsonPropertyName("game_alias")]
        public string? GameAlias { get; set; }

        [JsonPropertyName("game_image")]
        public string? GameImage { get; set; }

        [JsonPropertyName("game_type")]
        public string? GameType { get; set; }

        [JsonPropertyName("game_parent")]
        public int? GameParent { get; set; }

        [JsonPropertyName("profile_summary")]
        public string? ProfileSummary { get; set; }

        [JsonPropertyName("profile_dev")]
        public string? ProfileDev { get; set; }

        [JsonPropertyName("profile_pub")]
        public string? ProfilePub { get; set; }

        [JsonPropertyName("profile_platform")]
        public string? ProfilePlatform { get; set; }

        [JsonPropertyName("profile_genre")]
        public string? ProfileGenre { get; set; }

        [JsonPropertyName("profile_steam")]
        public int? ProfileSteam { get; set; }

        [JsonPropertyName("profile_steam_alt")]
        public int? ProfileSteamAlt { get; set; }

        [JsonPropertyName("profile_itch")]
        public int? ProfileItch { get; set; }

        [JsonPropertyName("profile_ign")]
        public string? ProfileIgn { get; set; }

        [JsonPropertyName("release_world")]
        public string? ReleaseWorld { get; set; }

        [JsonPropertyName("release_na")]
        public string? ReleaseNa { get; set; }

        [JsonPropertyName("release_eu")]
        public string? ReleaseEu { get; set; }

        [JsonPropertyName("release_jp")]
        public string? ReleaseJp { get; set; }

        [JsonPropertyName("rating_esrb")]
        public string? RatingEsrb { get; set; }

        [JsonPropertyName("rating_pegi")]
        public string? RatingPegi { get; set; }

        [JsonPropertyName("rating_cero")]
        public string? RatingCero { get; set; }

        [JsonPropertyName("comp_lvl_sp")]
        public int? CompLvlSp { get; set; }

        [JsonPropertyName("comp_lvl_spd")]
        public int? CompLvlSpd { get; set; }

        [JsonPropertyName("comp_lvl_co")]
        public int? CompLvlCo { get; set; }

        [JsonPropertyName("comp_lvl_mp")]
        public int? CompLvlMp { get; set; }

        [JsonPropertyName("comp_lvl_combine")]
        public int? CompLvlCombine { get; set; }

        [JsonPropertyName("comp_lvl_platform")]
        public int? CompLvlPlatform { get; set; }

        [JsonPropertyName("comp_all_count")]
        public int? CompAllCount { get; set; }

        [JsonPropertyName("comp_all")]
        public int? CompAll { get; set; }

        [JsonPropertyName("comp_all_l")]
        public int? CompAllL { get; set; }

        [JsonPropertyName("comp_all_h")]
        public int? CompAllH { get; set; }

        [JsonPropertyName("comp_all_avg")]
        public int? CompAllAvg { get; set; }

        [JsonPropertyName("comp_all_med")]
        public int? CompAllMed { get; set; }

        [JsonPropertyName("comp_main_count")]
        public int? CompMainCount { get; set; }

        [JsonPropertyName("comp_main")]
        public int? CompMain { get; set; }

        [JsonPropertyName("comp_main_l")]
        public int? CompMainL { get; set; }

        [JsonPropertyName("comp_main_h")]
        public int? CompMainH { get; set; }

        [JsonPropertyName("comp_main_avg")]
        public int? CompMainAvg { get; set; }

        [JsonPropertyName("comp_main_med")]
        public int? CompMainMed { get; set; }

        [JsonPropertyName("comp_plus_count")]
        public int? CompPlusCount { get; set; }

        [JsonPropertyName("comp_plus")]
        public int? CompPlus { get; set; }

        [JsonPropertyName("comp_plus_l")]
        public int? CompPlusL { get; set; }

        [JsonPropertyName("comp_plus_h")]
        public int? CompPlusH { get; set; }

        [JsonPropertyName("comp_plus_avg")]
        public int? CompPlusAvg { get; set; }

        [JsonPropertyName("comp_plus_med")]
        public int? CompPlusMed { get; set; }

        [JsonPropertyName("comp_100_count")]
        public int? Comp100Count { get; set; }

        [JsonPropertyName("comp_100")]
        public int? Comp100 { get; set; }

        [JsonPropertyName("comp_100_l")]
        public int? Comp100L { get; set; }

        [JsonPropertyName("comp_100_h")]
        public int? Comp100H { get; set; }

        [JsonPropertyName("comp_100_avg")]
        public int? Comp100Avg { get; set; }

        [JsonPropertyName("comp_100_med")]
        public int? Comp100Med { get; set; }

        [JsonPropertyName("comp_speed_count")]
        public int? CompSpeedCount { get; set; }

        [JsonPropertyName("comp_speed")]
        public int? CompSpeed { get; set; }

        [JsonPropertyName("comp_speed_min")]
        public int? CompSpeedMin { get; set; }

        [JsonPropertyName("comp_speed_max")]
        public int? CompSpeedMax { get; set; }

        [JsonPropertyName("comp_speed_avg")]
        public int? CompSpeedAvg { get; set; }

        [JsonPropertyName("comp_speed_med")]
        public int? CompSpeedMed { get; set; }

        [JsonPropertyName("comp_speed100_count")]
        public int? CompSpeed100Count { get; set; }

        [JsonPropertyName("comp_speed100")]
        public int? CompSpeed100 { get; set; }

        [JsonPropertyName("comp_speed100_min")]
        public int? CompSpeed100Min { get; set; }

        [JsonPropertyName("comp_speed100_max")]
        public int? CompSpeed100Max { get; set; }

        [JsonPropertyName("comp_speed100_avg")]
        public int? CompSpeed100Avg { get; set; }

        [JsonPropertyName("comp_speed100_med")]
        public int? CompSpeed100Med { get; set; }

        [JsonPropertyName("count_total")]
        public int? CountTotal { get; set; }

        [JsonPropertyName("invested_co_count")]
        public int? InvestedCoCount { get; set; }

        [JsonPropertyName("invested_co")]
        public int? InvestedCo { get; set; }

        [JsonPropertyName("invested_co_l")]
        public int? InvestedCoL { get; set; }

        [JsonPropertyName("invested_co_h")]
        public int? InvestedCoH { get; set; }

        [JsonPropertyName("invested_co_avg")]
        public int? InvestedCoAvg { get; set; }

        [JsonPropertyName("invested_co_med")]
        public int? InvestedCoMed { get; set; }

        [JsonPropertyName("invested_mp_count")]
        public int? InvestedMpCount { get; set; }

        [JsonPropertyName("invested_mp")]
        public int? InvestedMp { get; set; }

        [JsonPropertyName("invested_mp_l")]
        public int? InvestedMpL { get; set; }

        [JsonPropertyName("invested_mp_h")]
        public int? InvestedMpH { get; set; }

        [JsonPropertyName("invested_mp_avg")]
        public int? InvestedMpAvg { get; set; }

        [JsonPropertyName("invested_mp_med")]
        public int? InvestedMpMed { get; set; }

        [JsonPropertyName("added_stats")]
        public string? AddedStats { get; set; }
    }
}
