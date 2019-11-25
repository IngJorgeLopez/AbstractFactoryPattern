using AbstractFactoryDesignPattern.ProductExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.ProductExample
{
    interface IAbstractCoffeTable
    {
        Product CreateCoffeTable();
    }
}
