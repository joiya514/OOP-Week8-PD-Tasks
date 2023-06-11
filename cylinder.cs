using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Lab.BL
{
    class cylinder : circle
    {
        private double height;

        public cylinder()
            {
                
            }
        public cylinder(double radius, double height)
        {
            this.height = height;
            base.radius = radius;
        }
        public double getVolume()
        {
            double volume = height * getArea();
            return volume;
        }
    }
}
