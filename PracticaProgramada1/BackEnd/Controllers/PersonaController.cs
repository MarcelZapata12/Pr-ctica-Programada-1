using Abstracciones.Abstracciones;
using BackEnd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        IPersonaService _personaService;
        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }
        // GET: api/<PersonaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonaController>
        [HttpPost]
        public void Post([FromBody]Persona persona)
        {
            _personaService.AddPersona(persona);
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
