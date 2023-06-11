using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Task4.BL;

namespace Week8Task4.UI
{
    class shapeUI
    {
        public virtual void showArea(shape s)
        {
            Console.WriteLine(" The Shape is " + s.getShape() + " and Area is " + s.getArea());
        }
    }
}
