using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_28_Udemy.Entities
{
    internal class OutsorcedEmployee : Employee
    {
        public double AdicionalCharge { get; set; }

        public OutsorcedEmployee() { }

        public OutsorcedEmployee(string name, int hours, double valuePerHour, double adicionalCharge) : base(name, hours, valuePerHour)
        {
            AdicionalCharge = adicionalCharge;
        }

        public override double Paymennt()
        {
            return base.Paymennt() + 1.1 * AdicionalCharge;
        }
    }
}
