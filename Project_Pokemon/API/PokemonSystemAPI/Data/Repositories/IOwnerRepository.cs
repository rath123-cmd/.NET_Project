using PokemonSystemAPI.Models;

namespace PokemonSystemAPI.Data.Repositories
{
    public interface IOwnerRepository
    {
        OwnerModel Get(int id);
        List<OwnerModel> GetAll();
        List<PokemonModel> GetAllPokemons(int id);
    }
}