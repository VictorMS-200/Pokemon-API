using System.Linq.Expressions;
using System.Text.Json.Serialization;


namespace Pokemon.Models;

// Models for the Pokemon API
public class PokemonClass
{
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("height")]
    public float height { get; set; }

    [JsonPropertyName("weight")]
    public float weight { get; set; }

    [JsonPropertyName("sprites")]
    public Sprites sprite { get; set; }

    [JsonPropertyName("abilities")]
    public List<Abilities> abilities { get; set; }

    [JsonPropertyName("types")]
    public List<Types> types { get; set; }

    [JsonPropertyName("stats")]
    public List<Stats> stats { get; set; }

}
