using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1TapurDhiman
{
    internal abstract class Employee
    {
        //Fields
        public EmployeeType type;
        private int _EmployeeID;
        private string _EmployeeName;

        //Constructor
        public Employee(int id, string name)
        {
            _EmployeeID = id;
            _EmployeeName = name;
        }

        // properties
        public int EmployeeId
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }

        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }

        //Calculating Tax
        public double Tax
        {
            get { return Math.Round(0.2 * GrossEarnings, 2); }
        }

        //Calculating Net Earnings
        public double NetEarnings
        {
            get { return Math.Round(GrossEarnings - Tax, 2); }
        }
        public virtual double GrossEarnings
        {
            get { return -1; }

        }
    }
}
