using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TapurDhiman
{
    internal class HourlyEmployee : Employee
    {
        //Fields
        private double _hoursWorked;
        private double _hourlyWage;


        //derived class constructor with call to the base class constructor
        public HourlyEmployee(int id, string name, double numOfHours, double wage) : base(id, name)
        {
            this.type = EmployeeType.HourlyEmployee;
            this._hoursWorked = numOfHours;
            this._hourlyWage = wage;
        }

        //Properties
        public double HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }

        public double HourlyWage
        {
            get { return _hourlyWage; }
            set { _hourlyWage = value; }
        }

        //Gross Earnings
        public override double GrossEarnings
        {
            get
            {
                if (_hoursWorked <= 40)
                {
                    return _hourlyWage * _hoursWorked;
                }
                else
                {
                    return (40 * _hourlyWage) + ((_hoursWorked - 40) * _hourlyWage * 1.5);
                }
            }
        }
    }
}
