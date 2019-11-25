using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesignPattern.ProductExample.Models;

namespace AbstractFactoryDesignPattern.ProductExample
{
    class ConcreteModernCoffeTable : IAbstractCoffeTable
    {
        public Product CreateCoffeTable()
        {
            return new Product
            {
                Name = "Future Coffe Table",
                Color = "Black",
                Type = "Modern"
            };
        }
    }
}
