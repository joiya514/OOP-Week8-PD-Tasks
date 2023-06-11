using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Task1.BL
{
    class student : person
    {
        private string program;
        private int year;
        private double fee;

        public student(string name, string address, string program, int year, double fee)
        {
            base.name = name;
            base.address = address;
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string getProgram()
        {
            return program;
        }
        public int getYear()
        {
            return year;
        }
        public double getFee()
        {
            return fee;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public new string toString()
        {
            string data = base.toString();
            data += "\nProgram = " + program + " Year = " + year + " Fee = " + fee;
            return data;
        }
    }
}
