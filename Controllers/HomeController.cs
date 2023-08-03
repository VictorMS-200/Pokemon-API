using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokemon.Services;
using Pokemon_API.Models;

namespace Pokemon_API.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> PokemonList()
    {
        var pokemonList = await PokemonService.GetPokemonList();
        return View(pokemonList);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
