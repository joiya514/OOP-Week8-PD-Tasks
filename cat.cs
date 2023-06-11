using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task3.BL
{
    class cat : mammal
    {
        public cat(string name) : base(name)
        {

        }
        public override string toString()
        {
            string data = base.toString();
            data = "Cat [" + data + "]";
            greets();
            return data;
        }
        public void greets()
        {
            Console.WriteLine("Meow");
        }
    }
}
