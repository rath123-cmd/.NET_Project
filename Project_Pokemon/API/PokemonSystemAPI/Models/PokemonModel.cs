namespace PokemonSystemAPI.Models
{
    public class PokemonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public TypeModel Type { get; set; }
        public RegionModel Region { get; set; }
    }
}
