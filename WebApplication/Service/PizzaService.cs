using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components.Web;
using WebApplication.other;
using WebApplication.repositories;

namespace WebApplication.Service
{
    public class PizzaService
    {
        public static IEnumerable<Pizza> GetAll()
        {
            IEnumerable<Pizza> query =
                from pizza in PizzaRepository.GetPizzas()
                select new Pizza
                {
                    id = pizza.id, name = pizza.name, ingredients = pizza.ingredients, price = Converter.ConvertToEur(pizza.price)
                };
            return query;
        }


        public static IEnumerable<Pizza> GetPizzaByName(string name)
        {
            IEnumerable<Pizza> query =
                from pizz in PizzaRepository.GetPizzas()
                where pizz.name.Contains(name)
                select pizz;
            return query;
        }
        
    }
}