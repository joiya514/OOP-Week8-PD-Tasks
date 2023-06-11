using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task3.BL
{
    class mammal : animal
    {
        public mammal(string name) : base(name)
        {

        }
        public override string toString()
        {
            string data = base.toString();
            data = "Mammal [" + data + "]";
            return data;
        }
    }
}
