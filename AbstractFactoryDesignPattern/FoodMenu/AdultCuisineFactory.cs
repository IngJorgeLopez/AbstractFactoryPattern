using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.FoodMenu
{
    /// <summary>
    /// A ConcreteProduct
    /// </summary>
    class BLT : Sandwich { }

    /// <summary>
    /// A ConcreteProduct
    /// </summary>
    class CremeBrulee : Dessert { }

    /// <summary>
    /// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
    /// </summary>  
    class AdultCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new CremeBrulee(); 
        }

        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }
    }
}
