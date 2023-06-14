using System.Text.Json.Serialization;

namespace RaceList.Models
{
    public class RaceListBasic
    {
        [JsonPropertyName("series_1")]
        public Race[]? Series1 { get; set; }
        [JsonPropertyName("series_2")]
        public Race[]? Series2 { get; set; }
        [JsonPropertyName("series_3")]
        public Race[]? Series3 { get; set; }
    }
}
