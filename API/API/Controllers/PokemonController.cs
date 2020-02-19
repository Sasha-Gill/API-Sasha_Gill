using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        public static List<pokemon> pokemons = new List<pokemon>()
        {
            new pokemon() {Name = "Bergfors", Strenght = 69 },
            new pokemon() {Name = "flog", Strenght = 300 },
            new pokemon() {Name = "Tirak", Strenght = 200 }
        };

        [HttpGet]
        public ActionResult get()
        {

            /*pokemon p = new pokemon();
            p.Name = "Bergfors";
            p.Strenght = 69;*/

            return Ok(pokemons);
        }
    }
}