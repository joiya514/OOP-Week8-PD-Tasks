using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Task4.BL;

namespace Week8Task4.UI
{
    class rectangleUI : shape
    {
        public static rectangle takeInput()
        {
            rectangle r = new rectangle();
            Console.Write(" Enter Length: ");
            r.setLength(double.Parse(Console.ReadLine()));
            Console.Write(" Enter Width: ");
            r.setWidth(double.Parse(Console.ReadLine()));
            return r;
        }
    }
}
