using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task4.BL
{
    public class circle : shape
    {
        private double radius;
        public circle()
        {
            base.Shape = "Circle";
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            double area = (Math.PI * Math.Pow(radius, 2)) / 2;
            return area;
        }
    }
}
