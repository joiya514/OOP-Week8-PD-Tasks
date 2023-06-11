using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task1.BL
{
    class staff : person
    {
        private string school;
        private double pay;

        public staff(string name, string address, string school, double pay)
        {
            base.name = name;
            base.address = address;
            this.school = school;
            this.pay = pay;
        }

        public void setSchool(string school)
        {
            this.school = school;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public string getSchool()
        {
            return school;
        }
        public double getPay()
        {
            return pay;
        }
        public new string toString()
        {
            string data = base.toString();
            data += "\nSchool = " + school + " Pay = " + pay;
            return data;
        }
    }
}
