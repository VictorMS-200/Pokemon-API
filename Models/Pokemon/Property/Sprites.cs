using System.Text.Json.Serialization;

namespace Pokemon.Models;

public class Sprites
{
	[JsonPropertyName("front_default")]
	public string FrontDefault { get; set; }

	[JsonPropertyName("front_shiny")]
	public string FrontShiny { get; set; }

	
}
