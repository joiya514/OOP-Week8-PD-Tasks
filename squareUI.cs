using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Task4.BL;

namespace Week8Task4.UI
{
     class squareUI : shape
    {

        public static square takeInput()
        {
            square s = new square();
            Console.Write(" Enter Side: ");
            s.setSide(double.Parse(Console.ReadLine()));
            return s;
        }
    }
}
