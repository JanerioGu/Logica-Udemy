using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_31_Udemy.Entities
{
    public class Pf : Contribuinte
    {
        public double HelthExpenses { get; set; }

        public Pf() { }

        public Pf(string name, double income,double helthExpenses) :base(name, income)
        {
            HelthExpenses = helthExpenses;
        }

        public override double CalculationTaxe()
        {
            double taxes = 0;
            double hasHelthExpenses = 0;
            if (Income < 20000)
            {
                taxes = Income * 0.15;
            }
            else
            {
                taxes = Income * 0.20;
            }

            if (HelthExpenses > 0)
            {
                hasHelthExpenses = HelthExpenses/2;
            }
            return taxes - hasHelthExpenses;
        }
    }
}
