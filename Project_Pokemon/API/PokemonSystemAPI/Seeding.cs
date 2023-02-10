using PokemonSystemAPI.Data.DataContext;
using PokemonSystemAPI.Models;

namespace PokemonSystemAPI
{
    public class Seeding
    {
        private readonly PokemonSystemDbContext _dbContext;

        public Seeding(PokemonSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedData()
        {
            if (!_dbContext.Pokemons.Any())
            {
                var owners = new List<OwnerModel>
                {
                    new OwnerModel()
                    {
                        Name = "Rathin Karmakar",
                        BirthDate = DateTime.Now,
                        Region = new RegionModel()
                        {
                            Name = "WB"
                        },
                        Pokemons = new List<PokemonModel>
                        {
                            new PokemonModel()
                            {
                                Name = "Pikachu",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Thunder"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "WB"
                                }
                            },
                            new PokemonModel()
                            {
                                Name = "Charlizard",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Dragon"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "UP"
                                }
                            }
                        }
                    },
                    new OwnerModel()
                    {
                        Name = "Tapendu Karmakar",
                        BirthDate = DateTime.Now,
                        Region = new RegionModel()
                        {
                            Name = "TN"
                        },
                        Pokemons = new List<PokemonModel>
                        {
                            new PokemonModel()
                            {
                                Name = "Eevee",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Fox"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "AS"
                                }
                            },
                            new PokemonModel()
                            {
                                Name = "Snorlax",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Normal"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "KL"
                                }
                            },
                            new PokemonModel()
                            {
                                Name = "Lucario",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Aura"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "LA"
                                }
                            }
                        }
                    },
                    new OwnerModel()
                    {
                        Name = "Smriti Das",
                        BirthDate = DateTime.Now,
                        Region = new RegionModel()
                        {
                            Name = "PN"
                        },
                        Pokemons = new List<PokemonModel>
                        {
                            new PokemonModel()
                            {
                                Name = "Lucario",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Aura"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "LA"
                                }
                            },
                            new PokemonModel()
                            {
                                Name = "Ditto",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Normal"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "AP"
                                }
                            },
                            new PokemonModel()
                            {
                                Name = "Squirtle",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Water"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "MH"
                                }
                            },
                            new PokemonModel()
                            {
                                Name = "Bulbasaur",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Seed"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "MP"
                                }
                            },
                            new PokemonModel()
                            {
                                Name = "Gyarados",
                                BirthDate = DateTime.Now,
                                Type = new TypeModel()
                                {
                                    Name = "Dragon"
                                },
                                Region = new RegionModel()
                                {
                                    Name = "TN"
                                }
                            }
                        }
                    }
                };

                _dbContext.AddRange(owners);
                _dbContext.SaveChanges();
            }
        }
    }
}
