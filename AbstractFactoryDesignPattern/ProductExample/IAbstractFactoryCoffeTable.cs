using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.ProductExample
{
    interface IAbstractFactoryCoffeTable
    {
        IAbstractCoffeTable CreateModerCoffeTable();
        IAbstractCoffeTable CreateVictorianCoffeTable();
    }
}
