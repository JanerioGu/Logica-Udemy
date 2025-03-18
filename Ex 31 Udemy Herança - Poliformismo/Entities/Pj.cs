using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31_Udemy.Entities
{
    public class Pj : Contribuinte
    {
        public int EmployeeQuantity { get; set; }
        public Pj() { }
        public Pj(string name, double income,int employeeQuantity) : base(name, income) {
            EmployeeQuantity = employeeQuantity;
        }

        public override double CalculationTaxe()
        {
            double taxes = 0;

            if (EmployeeQuantity < 10)
            {
                taxes = Income * 0.16;
            }
            else
            {
                taxes = Income * 0.14;
            }

            return taxes;
        }
    }
}
