using System.Linq;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Models;
namespace PokemonAPI.Mappers
{
    public static class PokemonMapper
    {
      public static Pokemon ToModel(this IQueryable<Pokemon> pokemon)
        {
            return new Pokemon()
            {
                PokemonId = pokemon.FirstOrDefault().PokemonId,
                abilities = pokemon.
                                Include(x => x.abilities)
                                    .ThenInclude(x => x.ability)
                                .Select(x => x.abilities).FirstOrDefault(),
                base_experience = pokemon.FirstOrDefault().base_experience,
                forms = pokemon.Select(x => x.forms).FirstOrDefault(),
                game_indices = pokemon
                                    .Include(x => x.game_indices)
                                        .ThenInclude(x => x.version)
                                    .Select(x => x.game_indices).FirstOrDefault(),
                height = pokemon.FirstOrDefault().height,
                held_items = pokemon
                                    .Include(x => x.held_items)
                                        .ThenInclude(x => x.item)
                                    .Include(x => x.held_items)
                                        .ThenInclude(x => x.version_details)
                                    .Select(x => x.held_items).FirstOrDefault(),
                id = pokemon.FirstOrDefault().id,
                is_default = pokemon.FirstOrDefault().is_default,
                location_area_encounters = pokemon.FirstOrDefault().location_area_encounters,
                moves = pokemon
                                .Include(x => x.moves)
                                    .ThenInclude(x => x.move)
                                .Include(x => x.moves)
                                    .ThenInclude(x => x.version_group_details)
                                        .ThenInclude(x => x.move_learn_method)
                                .Include(x => x.moves)
                                    .ThenInclude(x => x.version_group_details)
                                        .ThenInclude(x => x.version_group)

                                .Select(x => x.moves).FirstOrDefault(),
                name = pokemon.FirstOrDefault().name,
                order = pokemon.FirstOrDefault().order,
                species = pokemon.Select(x => x.species).FirstOrDefault(),
                sprites = pokemon.Select(x => x.sprites).FirstOrDefault(),

                types = pokemon
                            .Include(x => x.types)
                                .ThenInclude(x => x.type)
                            .Select(x => x.types).FirstOrDefault(),
                weight = pokemon.FirstOrDefault().weight,
                stats = pokemon
                        .Include(x => x.stats)
                            .ThenInclude(x => x.stat)
                        .Select(x => x.stats).FirstOrDefault()

            };
        }
    }
}
