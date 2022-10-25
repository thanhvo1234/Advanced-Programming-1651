using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Programming_1651;

namespace Advanced_Programming_1651
{
    internal class SuperCar : Car
    {
        public SuperCar(int id, string brand, string _model, double price) : base(id, brand, _model, price)
        {
        }

        public override double Price
        {
            get
            {
                return base.Price * 1.3;
            }
            set
            {
                base.Price = value;
            }
        }
    }
}
