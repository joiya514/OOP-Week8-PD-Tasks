using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task4.BL
{
    class square : shape
    {
        private double side;

        public square()
        {
            base.Shape = "Square";
        }

        public void setSide(double side)
        {
            this.side = side;
        }
        public override double getArea()
        {
            double area = Math.Pow(side, 2);
            return area;
        }
    }
}
