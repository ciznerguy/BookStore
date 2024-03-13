using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    internal class Employee
    {
        private string name;
        private int salary;
        private bool IsMale;
        public Employee(string name, int salary, bool isMale)
        {
            this.name = name;
            this.salary = salary;
            IsMale = isMale;
        }
        public string GetName()
        {
            return name;
        }
        public int GetSalary()
        {
            return salary;
        }
        public void SetSalary(int salary)
        {
            this.salary= salary;

        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool IsHighSalary()
        {
            return this.salary > 20000;
        }
        public override string ToString()
        {
            return " name : " + this.name + "\n salary :" + this.salary + "\n IsMale : " + this.IsMale; 
        }
    }
}
