using System.Text.Json;
using Pokemon.Models;

namespace Pokemon.Services;


public class PokemonService
{
    private static List<PokemonClass> pokemonList = new List<PokemonClass>();

    public static List<PokemonClass> GetPokemonList()
    {
        using(var client = new HttpClient())
        {
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    var response = client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{i}").Result;

                    var content = response.Content.ReadAsStringAsync().Result;
                    var pokemon = JsonSerializer.Deserialize<PokemonClass>(content);

                    pokemonList.Add(pokemon!);
                }

                return pokemonList;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }
    }
}