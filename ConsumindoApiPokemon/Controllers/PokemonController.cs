using ConsumindoApiPokemon.Models;
using ConsumindoApiPokemon.Services;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nancy.Json;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ConsumindoApiPokemon.Controllers
{
    [ApiController, Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        string mens = string.Empty;

        private static readonly string[] Summaries = new[]
        {
            "Charmander", "Squirtle", "Caterpie", "Weedle", "Pidgey", "Pidgeotto", "Rattata", "Spearow", "Fearow", "Arbok", "Pikachu", "Sandshrew"
        };

        private readonly ILogger<PokemonController> _logger;

        public PokemonController(ILogger<PokemonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Limit")]
        public ObservableCollection<Results> GetColectionPokemosAsync(int intPokemon)
        {
            var url = PathApi.pathUrl + "pokemon/?offset=0&limit=" + intPokemon;
            using (var client = new HttpClient())
            {
                try
                {
                    var content = client.GetStringAsync(url).Result;
                    var json = JsonConvert.DeserializeObject<TodosPokemonsModel>(content);
                    return new ObservableCollection<Results>(json.results);
                }
                catch (Exception e)
                {
                    return new ObservableCollection<Results>();
                }
            }
        }

        [HttpGet]
        [Route("Pokemon")]
        public ObservableCollection<ResultAbility> GetPokemosAsync(string strPokemon)
        {
            var url = PathApi.pathUrl + "pokemon";
            using (var client = new HttpClient())
            {
                try
                {
                    var content = client.GetStringAsync(url).Result;
                    var json = JsonConvert.DeserializeObject<AbilityModel>(content);
                    return new ObservableCollection<ResultAbility>(json.results);
                }
                catch (Exception e)
                {
                    return new ObservableCollection<ResultAbility>();
                }
            }
        }

        [HttpGet]
        [Route("Types")]
        public ObservableCollection<Name> GetNomePokemosAsync(int intType)
        {
            var url = PathApi.pathUrl + "type/" + intType;
            using (var client = new HttpClient())
            {
                try
                {
                    var content = client.GetStringAsync(url).Result;
                    var json = JsonConvert.DeserializeObject<NamesTypes>(content);
                    return new ObservableCollection<Name>(json.names);
                }
                catch (Exception e)
                {
                    return new ObservableCollection<Name>();
                }
            }
        }

        [HttpGet]
        [Route("Abilitys")]
        public ObservableCollection<ResultAbility> GetAbilitysPokemosAsync()
        {
            var url = PathApi.pathUrl + "ability";
            using (var client = new HttpClient())
            {
                try
                {
                    var content = client.GetStringAsync(url).Result;
                    var json = JsonConvert.DeserializeObject<AbilityModel>(content);
                    return new ObservableCollection<ResultAbility>(json.results);
                }
                catch (Exception e)
                {
                    return new ObservableCollection<ResultAbility>();
                }
            }
        }
    }
}
