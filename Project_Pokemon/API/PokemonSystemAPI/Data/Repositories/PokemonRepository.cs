using PokemonSystemAPI.Data.DataContext;
using PokemonSystemAPI.Models;

namespace PokemonSystemAPI.Data.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonSystemDbContext _pokemonSystemDbContext;

        public PokemonRepository(PokemonSystemDbContext pokemonSystemDbContext)
        {
            _pokemonSystemDbContext = pokemonSystemDbContext;
        }

        public PokemonModel Get(int id)
        {
            var result = _pokemonSystemDbContext.Pokemons.Find(id);
            if (result == null)
            {
                return null;
            }
            return result;
        }

        public List<PokemonModel> GetAll()
        {
            var result = _pokemonSystemDbContext.Pokemons.ToList();

            return result;
        }

        public int Create(PokemonModel pokemonModel)
        {
            var res = _pokemonSystemDbContext.Add(pokemonModel);
            _pokemonSystemDbContext.SaveChanges();

            return res.Entity.Id;
        }

        public bool Delete(int id)
        {
            var toBeDelete = Get(id);
            if(toBeDelete != null)
            {
                var res = _pokemonSystemDbContext.Pokemons.Remove(toBeDelete);
                if (res.Entity.Id != 0)
                {
                    _pokemonSystemDbContext.SaveChanges();
                    return true;
                }
            }
           
            return false;
        }
    }
}
