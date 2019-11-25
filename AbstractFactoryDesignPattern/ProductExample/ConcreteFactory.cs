using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.ProductExample
{
    // Las fabricas concretas producen productos que pertenecen a una sola variante
    // la fábrica garantiza que los productos resultantes sean compatibles.
    // Ten en cuenta que el conjunto de métodos de la fábrica concreta devuelve 
    // un producto abstracto mientras que dentro de los métodos se instancia
    // un producto concreto,

    class ConcreteFactory : IAbstractFactorySofa, IAbstractFactoryCoffeTable
    {
        public IAbstractCoffeTable CreateModerCoffeTable()
        {
            return new ConcreteModernCoffeTable();
        }

        public IAbstractSofa CreateModernSofa()
        {
            return new ConcreteModernSofa();
        }

        public IAbstractCoffeTable CreateVictorianCoffeTable()
        {
            return new ConcreteVictorianCoffeTable();
        }

        public IAbstractSofa CreateVictorianSofa()
        {
            return new ConcreteVictorianSofa();
        }
    }
}
