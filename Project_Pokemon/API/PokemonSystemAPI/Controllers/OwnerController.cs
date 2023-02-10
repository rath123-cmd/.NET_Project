using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonSystemAPI.Data.Repositories;
using PokemonSystemAPI.Models;

namespace PokemonSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(OwnerModel))]
        public IActionResult Get(int id)
        {
            var result = _ownerRepository.Get(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<OwnerModel>))]
        public IActionResult GetAll()
        {
            var result = _ownerRepository.GetAll();
            if(result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpGet("get-pokemons/{id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<PokemonModel>))]
        public IActionResult GetAllPokemons(int id)
        {
            var result = _ownerRepository.GetAllPokemons(id);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }
    }
}
