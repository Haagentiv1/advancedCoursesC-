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
        public static List<Pizza> GetPizza()
        {
            List<Pizza> query = new List<Pizza>(
                from pizza in PizzaRepository.GetPizzas()
                select pizza);
            return query;


        }

        public static List<Pizza> GetAll()
        {
            List<Pizza> query =
                new List<Pizza>(from pizza in PizzaRepository.GetPizzas()
                    select new Pizza
                    {
                        id = pizza.id, name = pizza.name, ingredients = pizza.ingredients,
                        price = pizza.price.ConvertToEur()
                    });
            if (query.Count == 0)
            {
                throw new ArgumentException("There is no pizza avalable");
            }

            return query;
        }


        public static List<Pizza> GetPizzaByName(string name)
        {
            List<Pizza> query =
                new List<Pizza>(from pizz in PizzaRepository.GetPizzas()
                    where pizz.name.Contains(name)
                    select pizz);
            if (query.Count == 0)
            {
                throw new ArgumentException(name + ": is not available");

            }
            return query;
        }
        
        
        public static List<Pizza> GetPizzaByNameOrReturnAll(string name)
        {
            List<Pizza> query =
                new List<Pizza>(from pizz in PizzaRepository.GetPizzas()
                    where pizz.name.Contains(name)
                    select pizz);
            if (query.Count == 0)
            { 
                query = GetAll();
                if (query.Count == 0)
                {
                    throw new ArgumentException("There is no pizza available");
                }

                {
                    
                }
            }
            return query;
        }
    }
}