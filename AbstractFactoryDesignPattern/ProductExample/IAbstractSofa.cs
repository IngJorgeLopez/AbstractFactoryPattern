using AbstractFactoryDesignPattern.ProductExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.ProductExample
{
    // Para cada producto de una familia de productos debera tener una interfaz base
    // Todas las variantes del producto tienen que implementar esta interfaz
    interface IAbstractSofa
    {
        Product CreateSofa();
    }
}
