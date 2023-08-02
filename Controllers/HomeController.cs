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

    public IActionResult PokemonList()
    {
        var pokemonList = PokemonService.GetPokemonList();
        return View(pokemonList);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
