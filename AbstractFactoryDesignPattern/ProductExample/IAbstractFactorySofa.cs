using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.ProductExample
{
    // La interfaz Abstract factory declara un conjunto de métodos que retornan
    // diferentes productos abstractos. Esos productos son llamados una familia
    // y están relacionados por un concepto de alto nivel. Productos de una familia
    // son usualmente capaces de colaborar entre ellos. Una familia de productos puede
    // tener muchas variantes, pero los productos de una variante son incompatibles
    // con otras.

    interface IAbstractFactorySofa
    {
        IAbstractSofa CreateModernSofa();
        IAbstractSofa CreateVictorianSofa();
    }
}
