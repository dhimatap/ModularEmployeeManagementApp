using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TapurDhiman
{
    internal class SalariedPlusCommissionEmployee : CommissionEmployee
    {
        //Fields And Properties
        private double _fixedWeeklySalary;

        //derived class constructor with call to the base class constructor
        public SalariedPlusCommissionEmployee(int id, string name, double sales, double rate, double fixedWeeklySalary) : base(id, name, sales, rate)
        {

            type = EmployeeType.SalariedPlusCommissionEmployee;
            _fixedWeeklySalary = fixedWeeklySalary;
        }

        //Fields and properties
        public double fixedWeekSalary
        {
            get { return Math.Round(_fixedWeeklySalary, 2); }
            set { _fixedWeeklySalary = value; }
        }

        //Gross Earnings
        public override double GrossEarnings
        {
            get
            {
                return Math.Round(_fixedWeeklySalary + GrossSales * (0.01 * CommissionRate), 2);

            }
        }
    }
}
