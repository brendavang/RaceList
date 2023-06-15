using System.Text.Json.Serialization;

namespace RaceList.Models
{
    public class Race
    {
        [JsonPropertyName("race_id")]
        public int RaceId { get; set; }
        [JsonPropertyName("series_id")]
        public int SeriesId { get; set; }
        [JsonPropertyName("race_name")]
        public string? RaceName { get; set; }
        [JsonPropertyName("track_name")]
        public string? TrackName { get; set; }
        [JsonPropertyName("race_date")]
        public DateTime RaceDate { get; set; }
        [JsonPropertyName("scheduled_distance")]
        public float ScheduledDistance { get; set; }
        [JsonPropertyName("scheduled_laps")]
        public int ScheduledLaps { get; set; }
        
    }
}
