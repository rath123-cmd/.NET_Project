namespace PokemonSystemAPI.Models
{
    public class OwnerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public RegionModel Region { get; set; }
        public ICollection<PokemonModel> Pokemons { get; set; }
    }
}
