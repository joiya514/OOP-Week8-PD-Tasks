using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task3.BL
{
    class dog : mammal
    {
        public dog(string name) : base(name)
        {

        }

        public override string toString()
        {
            string data = base.toString();
            data = "Dog [" + data + "]";
            greets();
            return data;
        }
        public void greets()
        {
            Console.WriteLine("Woof");
        }
        public void greets(dog another)
        {
            Console.WriteLine("Woooof");
        }
    }
}
