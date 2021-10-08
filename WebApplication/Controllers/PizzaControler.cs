using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Logging;
using WebApplication.repositories;
using WebApplication.Service;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Pizza>> Get()
        {
            try
            {
                return Ok(PizzaService.GetAll());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500);
            }
            

        }

        [HttpGet]
        [Route("{name}")]
        public IEnumerable<Pizza> GetByName(String name)
        {
            return PizzaService.GetPizzaByName(name);
        }
    }
}