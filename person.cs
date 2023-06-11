using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task1.BL
{
    class person
    {
        protected string name;
        protected string address;

        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public void setName(string Name)
        {
            name = Name;
        }
        public string toString()
        {
            string data;
            data = "Person [Name = " + name + ", Address = " + address + "]";
            return data;
        }
    }
}
