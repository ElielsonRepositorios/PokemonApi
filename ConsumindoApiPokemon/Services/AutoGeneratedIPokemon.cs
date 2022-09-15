﻿using ConsumindoApiPokemon.Models;
using DocumentFormat.OpenXml.Vml.Office;
using Refit;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumindoApiPokemon.Services
{
    partial class AutoGeneratedIPokemon : IPokemonService
    {
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        public AutoGeneratedIPokemon(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        public Task<PokemonModel> GetPokemonAsync(string name)
        {
            var arguments = new object[] { name };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetPokemonAsync", new Type[] { typeof(string) });
            return (Task<PokemonModel>)func(Client, arguments);
        }

        public Task GetPokemonAsync(Entry entry_pokemon)
        {
            throw new System.NotImplementedException();
        }
    }
}
