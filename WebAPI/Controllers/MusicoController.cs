using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;
using WebAPI.Interfaces;
using WebAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicoController : ControllerBase
    {
        // GET: api/<MusicoController>
        private readonly IMusicoService _musicoService;

        public MusicoController(IMusicoService musicoService)

        { 
            _musicoService = musicoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_musicoService.Get());
            
        }

        // GET api/<MusicoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_musicoService.GetById(id));
        }

        // POST api/<MusicoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MusicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MusicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
