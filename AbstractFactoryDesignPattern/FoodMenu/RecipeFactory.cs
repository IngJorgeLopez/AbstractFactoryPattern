using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.FoodMenu
{
    /// <summary>
    /// AbstractFactory class
    /// </summary>
    abstract class RecipeFactory
    {
        public abstract Sandwich CreateSandwich();
        public abstract Dessert CreateDessert();
    }
}
