using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Task4.BL;

namespace Week8Task4.UI
{
    public class circleUI : shape
    {
        public static circle takeInput()
        {
            circle c = new circle();
            Console.Write(" Enter Radius: ");
            c.setRadius(double.Parse(Console.ReadLine()));
            return c;
        }
    }
}
