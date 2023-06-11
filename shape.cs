using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task4.BL
{
    public class shape
    {
        protected string Shape;

        public void setShape(string shape)
        {
            this.Shape = shape;
        }
        public string getShape()
        {
            return Shape;
        }
        public virtual double getArea()
        {
            double area = 0;
            return area;
        }
        

    }
}
