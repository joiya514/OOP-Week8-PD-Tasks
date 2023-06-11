using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task3.BL
{
    class animal
    {
        protected string name;

        public animal(string name)
        {
            this.name = name;
        }

        
        public virtual string toString()
        {
            string data = "Animal [Name = " + name + "]";
            return data;
        }
    }
}
