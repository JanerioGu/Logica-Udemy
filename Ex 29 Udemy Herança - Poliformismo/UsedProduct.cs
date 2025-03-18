using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_29_Udemy
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }
        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            this.ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $"Manufacture data: {ManufactureDate.ToString()}";
        }
    }
}
