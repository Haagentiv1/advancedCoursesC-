using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public IEnumerable<Pizza> Get()
        {
           return PizzaService.GetAll();
        }
        
        //[HttpGet]
        public IEnumerable<Pizza> GetByName(String name)
        {
            return PizzaService.GetPizzaByName("orientale");
        }


    }
}