using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task4.BL
{
    class rectangle : shape
    {
        private double length;
        private double width;
        public rectangle()
        {
            base.Shape = "Rectangle";
        }

        public void setLength(double length)
        {
            this.length = length;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public override double getArea()
        {
            double area = length * width;
            return area;
        }
    }
}
