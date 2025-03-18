using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31_Udemy.Entities
{
    public abstract class Contribuinte
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Contribuinte() { }

        public Contribuinte(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double CalculationTaxe();
    }
}
