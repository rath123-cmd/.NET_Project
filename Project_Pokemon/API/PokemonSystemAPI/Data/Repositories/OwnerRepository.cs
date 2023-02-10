using PokemonSystemAPI.Data.DataContext;
using PokemonSystemAPI.Models;

namespace PokemonSystemAPI.Data.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly PokemonSystemDbContext _pokemonSystemDbContext;

        public OwnerRepository(PokemonSystemDbContext pokemonSystemDbContext)
        {
            _pokemonSystemDbContext = pokemonSystemDbContext;
        }

        public OwnerModel Get(int id)
        {
            var result = _pokemonSystemDbContext.Owners.Find(id);
            if (result == null)
            {
                return null;
            }
            return result;
        }

        public List<OwnerModel> GetAll()
        {
            var result = _pokemonSystemDbContext.Owners.ToList();

            return result;
        }

        public List<PokemonModel> GetAllPokemons(int id)
        {
            var owner = Get(id);
            if (owner == null)
                return null;
            return _pokemonSystemDbContext.Pokemons.Where(p => p.);
        }
    }
}
