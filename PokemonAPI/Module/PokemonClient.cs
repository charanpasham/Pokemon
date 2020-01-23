using System;
using System.Net.Http;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Z.EntityFramework.Plus;
using PokemonAPI.Context;
using PokemonAPI.Mappers;
using PokemonAPI.Models;


namespace PokemonAPI.Module
{
    public interface IPokemonClient
    {
        Task<Pokemon> PokemonInfoByDexNumber(int pokeDexNumber);
        Task<PokemonList> PokemonList(int offset, int limit);
    }

    public  class PokemonClient : IPokemonClient
    {
        private readonly string PokemonApiUrl;
        private readonly HttpClient _httpClient;

        private readonly PokemonContext _context;

        public PokemonClient(IConfiguration configuration, PokemonContext pokemonContext)
        {
            _context = pokemonContext;
            PokemonApiUrl = configuration["PokemonAPI"];
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(PokemonApiUrl)
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

       public Task<Pokemon> PokemonInfoByDexNumber(int pokeDexNumber)
       {
           return CacheManager<Pokemon>.HttpGet(pokeDexNumber,  async () =>
            {
                var pokemonFound = _context.Pokemon.Where(x => x.id == pokeDexNumber);

                    if (pokemonFound.FirstOrDefault() == null)
                    {
                        var response = await _httpClient.GetAsync($"pokemon/{pokeDexNumber}");
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            var Pokemon = JsonSerializer.Deserialize<Pokemon>(json);
                            _context.Pokemon.Add(Pokemon);
                            await _context.SaveChangesAsync();
                            return Pokemon;
                        }
                    // if not found (or) error in pokeAPI, return a null object.
                    return new Pokemon();
                    }
                    return pokemonFound.ToModel();
            });
        }

        public async Task<PokemonList> PokemonList(int offset, int limit)
        {
            var response = await _httpClient.GetAsync($"pokemon?offset={offset}&limit={limit}");
            if(response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var pokeList = JsonSerializer.Deserialize<PokemonList>(json);
                if(pokeList.results.Count > 0)
                {
                    foreach(var res in pokeList.results)
                    {
                        var uri = new Uri(res.url);
                        var pokeDexNum = Convert.ToInt32(uri.AbsolutePath.Split('/')[4]);
                        var storeInCache = await PokemonInfoByDexNumber(pokeDexNum);
                    }
                }
                return pokeList;
            }
            return new PokemonList();
        }

    }
}
