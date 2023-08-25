using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TapurDhiman
{
    internal class CommissionEmployee : Employee
    {
        //Fields and properties
        private double _grossSales;
        private double _commissionRate;

        //derived class constructor with call to the base class constructor
        public CommissionEmployee(int id, string name, double sales, double rate) : base(id, name)
        {
            GrossSales = sales;
            CommissionRate = rate;
            type = EmployeeType.CommissionEmployee;
        }

        //properties
        public double GrossSales
        {
            get { return Math.Round(_grossSales, 2); }
            set { _grossSales = value; }
        }

        //Commission RATE
        public double CommissionRate
        {
            get { return Math.Round(_commissionRate, 2); }
            set { _commissionRate = value; }
        }

        //Gross earnings
        public override double GrossEarnings
        {
            get
            {
                return GrossSales * (0.01 * _commissionRate);

            }
        }
    }

}
