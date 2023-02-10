using Microsoft.EntityFrameworkCore;
using PokemonSystemAPI.Models;

namespace PokemonSystemAPI.Data.DataContext
{
    public class PokemonSystemDbContext: DbContext
    {
        public PokemonSystemDbContext(DbContextOptions<PokemonSystemDbContext> dbContextOptions)
            : base(dbContextOptions)
        { }

        public DbSet<PokemonModel> Pokemons { get; set; }
        public DbSet<OwnerModel> Owners { get; set; }
        public DbSet<RegionModel> Regions { get; set; }
        public DbSet<TypeModel> Types { get; set; }
    }
}
