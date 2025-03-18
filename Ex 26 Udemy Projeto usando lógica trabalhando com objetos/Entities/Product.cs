using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_26_Udemy_Projeto_usando_lógica_trabalhando_com_objetos.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
