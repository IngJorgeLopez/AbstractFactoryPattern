using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesignPattern.ProductExample.Models;

namespace AbstractFactoryDesignPattern.ProductExample
{
    class ConcreteModernSofa : IAbstractSofa
    {
        public Product CreateSofa()
        {
            return new Product
            {
                Name = "Future Sofa",
                Color = "White",
                Type = "Modern"
            };
        }
    }
}
