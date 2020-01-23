using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PokemonAPI.Module;
using PokemonAPI.Models;
namespace PokemonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {

        private readonly ILogger<PokemonController> _logger;
        private readonly IPokemonClient _pokemonClient;

        /// <summary>
        /// 
        /// </summary>
        public PokemonController(ILogger<PokemonController> logger, IPokemonClient client)
        {
            _logger = logger;
            _pokemonClient = client;
        }
        /// <summary>
        /// Get the pokemon details by Id,
        /// This query will take some time to execute, once it executes, it stores the data in the cache.
        /// </summary>
        /// <param name="id">Poke dex number</param>
        /// <returns>returns the pokemon object.</returns>
        [HttpGet("{id}")]
        public async Task<Pokemon> Get(int id)
        {
            return await _pokemonClient.PokemonInfoByDexNumber(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("PokemonList")]
        public async Task<PokemonList> PokemonList(int offset, int limit)
        {
            return await _pokemonClient.PokemonList(offset, limit);
        }

    }
}
