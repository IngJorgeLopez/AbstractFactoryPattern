using AbstractFactoryDesignPattern.FoodMenu;
using AbstractFactoryDesignPattern.ProductExample;
using AbstractFactoryDesignPattern.ProductExample.Models;
using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        /**************************************************************/

        // Creado por Jorge Adolfo López Huerta
        // Patrón de diseño: ABSTRACT FACTORY
        // Abstract factory es un patron de diseño creacional,
        // que resuelve el problema  de crear familias completas
        // de productos sin especificar sus clases concretas.

        // Abstract factory define una interfaz para crear todos los
        // distintos productos, pero deja la creación real del producto 
        // a clases concretas de la fábrica. Cada tipo de fábrica corresponde
        // a un cierto variante del producto.

        // Documentación: https://refactoring.guru/design-patterns/abstract-factory/csharp/example

        /**************************************************************/

        static void Main(string[] args)
        {
            //ExampleMenu();

            ExampleFurniture();
        }

        static void ExampleMenu()
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;
            RecipeFactory factory;
            switch (input)
            {
                case 'A':
                    factory = new AdultCuisineFactory();
                    break;

                case 'C':
                    factory = new KidCuisineFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);

        }

        static void ExampleFurniture()
        {
            ConcreteFactory concreteFactory = new ConcreteFactory();
            Console.WriteLine("Select (1) for sofa or (2) for coffe table");
            int option = int.Parse(Console.ReadLine());
            int newOption = 0;

            switch (option)
            {
                case 1:
                    Console.WriteLine("Select (1) for modern sofa or (2) for victorian sofa");
                    newOption = int.Parse(Console.ReadLine());
                    if (newOption == 1)
                        ClientSofaProduct(concreteFactory.CreateModernSofa());
                    else
                        ClientSofaProduct(concreteFactory.CreateVictorianSofa());
                    break;
                case 2:
                    Console.WriteLine("Select (1) for modern coffe table or (2) for victorian coffe table");
                    newOption = int.Parse(Console.ReadLine());
                    if (newOption == 1)
                        ClientCoffeTableProduct(concreteFactory.CreateModerCoffeTable());
                    else
                        ClientCoffeTableProduct(concreteFactory.CreateVictorianCoffeTable());
                    break;
                default:
                    Console.WriteLine("Goodbye!!!");
                    break;
            }
        }

        static void ClientSofaProduct(IAbstractSofa factory)
        {
            Product product = factory.CreateSofa();
            Console.WriteLine($"Your sofa is {product.Name}, it is {product.Type} and it has color {product.Color}");
        }

        static void ClientCoffeTableProduct(IAbstractCoffeTable factory)
        {
            Product product = factory.CreateCoffeTable();
            Console.WriteLine($"Your coffe table is {product.Name}, it is {product.Type} and it has color {product.Color}");
        }
    }
}
