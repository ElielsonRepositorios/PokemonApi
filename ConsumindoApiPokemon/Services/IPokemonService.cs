using ConsumindoApiPokemon.Models;
using DocumentFormat.OpenXml.Vml.Office;
using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Threading.Tasks;

namespace ConsumindoApiPokemon.Services
{
    public interface IPokemonService
    {
        [Get("/pokemon/{name}")]
        Task<PokemonModel> GetPokemonAsync(string name);
        Task GetPokemonAsync(Entry entry_pokemon);
    }
}
