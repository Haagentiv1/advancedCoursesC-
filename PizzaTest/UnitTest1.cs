using System;
using System.Linq;
using NUnit.Framework;
using WebApplication.Service;


namespace PizzaTest
{
    public class Tests
    
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPizzaGetOne_Returntrue()
        {

            var result = PizzaService.GetPizza()[0].name;
            Assert.True(result == "hawaian");
        }
    }
}