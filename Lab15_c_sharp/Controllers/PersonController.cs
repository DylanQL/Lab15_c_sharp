using Lab15_c_sharp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lab15_c_sharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        // 8. Agregar seguridad a un endpoint sin especificar el rol
        [Authorize]
        [HttpGet("Get2")]
        public IEnumerable<PersonResponse> Get2()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for (int i = 1; i <= 100; i++)
            {
                PersonResponse persona = new PersonResponse();
                persona.FirstName = "Persona" + i;
                persona.LastName = "Apellido" + i;

                personas.Add(persona);
            }

            return personas;
        }

        // 9. Agregar seguridad a un endpoint especificando el rol correcto
        [Authorize(Roles = "Administrador")]
        [HttpGet("Get")]
        public IEnumerable<PersonResponse> Get()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for (int i = 1; i <= 100; i++)
            {
                PersonResponse persona = new PersonResponse();
                persona.FirstName = "Persona" + i;
                persona.LastName = "Apellido" + i;

                personas.Add(persona);
            }

            return personas;
        }

        // 10. Agregar seguridad a un endpoint especificando el rol incorrecto
        [Authorize(Roles = "Vendedor")]
        [HttpGet("Get3")]
        public IEnumerable<PersonResponse> Get3()
        {
            List<PersonResponse> personas = new List<PersonResponse>();

            for (int i = 1; i <= 100; i++)
            {
                PersonResponse persona = new PersonResponse();
                persona.FirstName = "Persona" + i;
                persona.LastName = "Apellido" + i;

                personas.Add(persona);
            }

            return personas;
        }
    }
}
