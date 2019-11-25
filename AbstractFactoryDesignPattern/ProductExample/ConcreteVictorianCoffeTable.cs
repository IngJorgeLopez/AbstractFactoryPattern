using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesignPattern.ProductExample.Models;

namespace AbstractFactoryDesignPattern.ProductExample
{
    class ConcreteVictorianCoffeTable : IAbstractCoffeTable
    {
        public Product CreateCoffeTable()
        {
            return new Product
            {
                Name = "Clasic Coffe Table",
                Color = "Brown",
                Type = "Victorian"
            };
        }
    }
}
