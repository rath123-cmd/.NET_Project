using Microsoft.AspNetCore.Mvc;
using PokemonSystemAPI.Data.Repositories;
using PokemonSystemAPI.Models;

namespace PokemonSystemAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(PokemonModel))]
        public IActionResult Get(int id)
        {
            var result = _pokemonRepository.Get(id);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<PokemonModel>))]
        public IActionResult GetAll()
        {
            var result = _pokemonRepository.GetAll();
            if(result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(int))]
        public IActionResult Create(PokemonModel pokemonModel)
        {
            if (ModelState.IsValid)
            {
                var res = _pokemonRepository.Create(pokemonModel);
                
                return Ok(res);
            }

            return BadRequest();
        }

        [HttpDelete]
        [ProducesResponseType(200)]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                if(_pokemonRepository.Delete(id))
                    return Ok();
            }
            return BadRequest();
        }
    }
}
