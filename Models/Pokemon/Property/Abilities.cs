using System.Text.Json.Serialization;

namespace Pokemon.Models;

public class Abilities
{
    [JsonPropertyName("ability")]
    public AbilityName ability { get; set; }

    public class AbilityName
    {
        [JsonPropertyName("name")]
        public string name { get; set; }
    }

}