using Business.Adapters;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Dogrula()
        {
            Citizen citizen = new Citizen
            {
                Name = "Özgür",
                BirhYear = 1990,
                CitizenId = "12345678910",
                SurName = "Menteşe"
            };

            var result = _personService.VerifyCId(citizen);
            if (result.Result)
            {
                return Ok("Doğrulandı");
            }
            return BadRequest("Doğrulanmadı");
        }
    }
}
