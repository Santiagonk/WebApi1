using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
public class Puerta
{

    int ancho;     // Ancho en centimetros
    int alto;      // Alto en centimetros
    int color;     // Color en formato RGB
    bool abierta;  // Abierta o cerrada

    public void Abrir()
    {
        abierta = true;
    }

    public void Cerrar()
    {
        abierta = false;
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Abierta: {0}", abierta);
    }

}



namespace WebApi1.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            Puerta p = new Puerta();

            Console.WriteLine("Valores iniciales...");
            p.MostrarEstado();

            Console.WriteLine();

            Console.WriteLine("Vamos a abrir...");
            p.Abrir();
            p.MostrarEstado();
            return Ok(new object[] { 
                new { Id = 1, Nombre = "Cliente 1", Apellido = "Apellido 1"},
                new { Id = 2, Nombre = "Cliente 2", Apellido = "Apellido 2"}
            });
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
