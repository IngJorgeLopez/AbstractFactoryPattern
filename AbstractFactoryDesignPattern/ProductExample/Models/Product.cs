using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.ProductExample.Models
{
    // Para este ejemplo tenemos un producto universal, el cual
    // varia la información depende el tipo de producto pedido
    public class Product
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
    }
}
