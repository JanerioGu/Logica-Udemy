using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_25_Udemy_Projeto.Entities
{
    internal class HourContract
    {

        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public HourContract() { 
        
        }
        public double TotalValue() {
            double total = ValuePerHour * Hours;
            return total;
        }
    }
}
