using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeClient;

namespace PokemonUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private PokemonClient client;
        public PokemonController(PokemonClient _client)
        {
            client = _client;
        }
        [HttpGet("GetById/{id}")]
        public async Task<Pokemon> GetPokemonById(int id)
        {
            var pokemon = await client.GetAsync(id);
            return pokemon;
        }

        [HttpGet("List/{offset}/{limit}")]

        public async Task<IEnumerable<Pokemon>> GetPokemonList(int offset, int limit)
        {
            List<Task<Pokemon>> taskList = new List<Task<Pokemon>>();
            var pokemonList = await client.PokemonListAsync(offset, limit);
            for (int i = offset; i <= (limit+offset); i++)
            {
                taskList.Add(GetPokemonById(i));
            }
            var l= await Task.WhenAll(taskList);
            return l;
        }
    }
}