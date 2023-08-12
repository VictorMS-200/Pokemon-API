using System.Diagnostics;
using System.Text.Json;
using Pokemon.Models;

namespace Pokemon.Services;


public class PokemonService
{
    private static int confirm = 0; // Confirm if the list is already filled
    private static List<PokemonClass> pokemonList = new List<PokemonClass>();

    public static async Task<List<PokemonClass>> GetPokemonList()
    {
        if (confirm == 1)
        {
            return pokemonList;
        }

        using (var client = new HttpClient())
        {
            try
            {
                // Define the list of Pokemons 
                for (int i = 1; i <= 151; i++)
                {

                    var response = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{i.ToString()}");
                    var pokemon = JsonSerializer.Deserialize<PokemonClass>(response);

                    pokemonList.Add(pokemon!);
                }

                confirm++;
                return pokemonList;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
            
        }
    }

    public static PokemonClass GetPokemon(int id)
    {
        return pokemonList[id];
    }
}