using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_29_Udemy
{
    public class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(double customFee, string name, double price) : base(name, price)
        {
            this.CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $"(Customs fee: {CustomFee})";
        }
        public double TotalPrice()
        {
            return Price + CustomFee;
        }
    }
}
