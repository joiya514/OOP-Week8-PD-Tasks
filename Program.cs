using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8Task4.BL;
using Week8Task4.UI;

namespace Week8Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            circle c1 = circleUI.takeInput();
            square s1 = squareUI.takeInput();
            rectangle r1 = rectangleUI.takeInput();
            rectangle r2 = rectangleUI.takeInput();
            circle c2 = circleUI.takeInput();
            List<shape> data = new List<shape>() { c1, s1, r1, r2, c2};

            foreach(shape s in data)
            {
                shapeUI s11 = new shapeUI();
                s11.showArea(s);
            }
            Console.ReadKey();
        }
    }
}
