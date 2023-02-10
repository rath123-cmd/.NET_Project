using PokemonSystemAPI.Models;

namespace PokemonSystemAPI.Data.Repositories
{
    public interface IPokemonRepository
    {
        PokemonModel Get(int id);
        List<PokemonModel> GetAll();
        int Create(PokemonModel pokemonModel);
        bool Delete(int id);
    }
}