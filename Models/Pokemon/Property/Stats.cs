using System.Text.Json.Serialization;

namespace Pokemon.Models;

public class Stats
{
    [JsonPropertyName("base_stat")]
    public float statusBase { get; set; }
}