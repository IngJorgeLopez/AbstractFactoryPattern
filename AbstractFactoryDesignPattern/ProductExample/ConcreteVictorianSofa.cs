using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDesignPattern.ProductExample.Models;

namespace AbstractFactoryDesignPattern.ProductExample
{
    class ConcreteVictorianSofa : IAbstractSofa
    {
        public Product CreateSofa()
        {
            return new Product
            {
                Name = "Classic Sofa",
                Color = "Brown",
                Type = "Victorian"
            };
        }
    }
}
