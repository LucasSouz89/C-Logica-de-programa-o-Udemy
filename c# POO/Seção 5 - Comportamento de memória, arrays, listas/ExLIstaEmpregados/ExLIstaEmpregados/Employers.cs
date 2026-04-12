using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLIstaEmpregados {
    internal class Employers {
        private int _id;
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public int Id {
            get { return _id; }
            set { if(value > 99 && value < 1000) _id = value; }
        }

        public Employers(int id,string name,double salary ) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SalaryIncrease(double pct) {
            Salary += Salary * pct / 100.00;
        }
        public override string ToString() {
            return $"{Id}, {Name}, {Salary}";
        }
    }
}
