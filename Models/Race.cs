using System.Text.Json.Serialization;

namespace RaceList.Models
{
    public class Race
    {
        [JsonPropertyName("race_id")]
        public int RaceId { get; set; }
        [JsonPropertyName("series_id")]
        public int SeriesId { get; set; }
        [JsonPropertyName("race_season")]
        public int RaceSeason { get; set; }
        [JsonPropertyName("race_name")]
        public string? RaceName { get; set; }
        [JsonPropertyName("race_type_id")]
        public int RaceTypeId { get; set; }
        [JsonPropertyName("restrictor_plate")]
        public bool RestrictorPlate { get; set; }
        [JsonPropertyName("track_id")]
        public int TrackId { get; set; }
        [JsonPropertyName("track_name")]
        public string? TrackName { get; set; }
        [JsonPropertyName("date_scheduled")]
        public DateTime DateScheduled { get; set; }
        [JsonPropertyName("race_date")]
        public DateTime RaceDate { get; set; }
        [JsonPropertyName("qualifying_date")]
        public DateTime QualifyingDate { get; set; }
        [JsonPropertyName("tunein_date")]
        public DateTime TuneInDate { get; set; }
        [JsonPropertyName("scheduled_distance")]
        public float ScheduledDistance { get; set; }
        [JsonPropertyName("scheduled_laps")]
        public int ScheduledLaps { get; set; }
        
    }
}
