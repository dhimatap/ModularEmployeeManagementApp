using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TapurDhiman
{
    internal class SalariedEmployee : Employee
    {
        //Fields and Properties
        private double _weeklySalary;

        //derived class constructor with call to the base class constructor
        public SalariedEmployee(int id, string name, double weeklySalary) : base(id, name)
        {
            this.type = EmployeeType.SalariedEmployee;
            _weeklySalary = weeklySalary;
        }

        //properties
        public double WeekSalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        //Override Gross Earning
        public override double GrossEarnings
        {
            get { return _weeklySalary; }
        }
    }

}
