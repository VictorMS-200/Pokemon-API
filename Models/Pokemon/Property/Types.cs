using System.Text.Json.Serialization;

namespace Pokemon.Models;

public class Types
{
    [JsonPropertyName("type")]
		public TypeName type { get; set; }

    public class TypeName
    {
        [JsonPropertyName("name")]
		    public string name { get; set; }
    }
}