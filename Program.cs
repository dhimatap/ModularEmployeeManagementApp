namespace A1TapurDhiman
{
    internal class Program
    {
        static int id = 1;

        public static Dictionary<string, Employee> Employee = new Dictionary<string, Employee>();
        static void Main(string[] args)
        {
            addSampleData();

            menu();
        }

        //Populating the dictionary with some initial data of employees
        static void addSampleData()
        {
            Employee.Add("John", new HourlyEmployee(id++, "John", 40.0, 20.0));
            Employee.Add("Anne", new HourlyEmployee(id++, "Anne", 50.0, 15.0));
            Employee.Add("Emma", new CommissionEmployee(id++, "Emma", 10000.0, 20));
            Employee.Add("Mark", new CommissionEmployee(id++, "Mark", 80000.0, 15));
            Employee.Add("Sam", new SalariedEmployee(id++, "Sam", 800.0));
            Employee.Add("Miya", new SalariedEmployee(id++, "Miya", 1100.0));
            Employee.Add("Sandy", new SalariedPlusCommissionEmployee(id++, "Sandy", 5000.0, 10.0, 500.0));
            Employee.Add("Helen", new SalariedPlusCommissionEmployee(id++, "Helen", 8000.0, 12.0, 300.0));
        }

        static void menu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Assignment - 1 Tapur Dhiman");
            Console.WriteLine("*****************************\n\n");
            Console.WriteLine("1 - Add Employee ");
            Console.WriteLine("2 - Edit Employee ");
            Console.WriteLine("3 - Delete Employee ");
            Console.WriteLine("4 - View Employee ");
            Console.WriteLine("5 - Search Employee ");
            Console.WriteLine("6 - Exit ");
            Console.WriteLine("\n");

            while (true)
            {
                try
                {
                    Console.WriteLine("Choose Option ( 1 - 6 ) : ");
                    char option = char.Parse(Console.ReadLine());

                    if (option == '1')
                    {
                        addMenu();
                        break;
                    }
                    else if (option == '2')
                    {
                        editMenu();
                        break;
                    }
                    else if (option == '3')
                    {
                        deleteMenu();
                        break;
                    }
                    else if (option == '4')
                    {
                        ViewHourlyEmployees();
                        Console.WriteLine("\n");
                        ViewCommissionEmployees();
                        Console.WriteLine("\n");
                        ViewSalariedEmployees();
                        Console.WriteLine("\n");
                        ViewSalariedPlusCommissionEmployee();
                        Console.WriteLine("\n");
                        Console.WriteLine("Press Any Key to continue...");
                        Console.ReadKey();
                        menu();
                        break;
                    }
                    else if (option == '5')
                    {
                        SearchEmployees();
                        break;
                    }
                    else if (option == '6')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input Entered");

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input Entered\n");
                }
            }
        }

        static void addMenu()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("1 - Add Hourly Employee");
            Console.WriteLine("2 - Add Commission Employee ");
            Console.WriteLine("3 - Add Salaried Employee");
            Console.WriteLine("4 - Add Salary Plus Commission Employee ");
            Console.WriteLine("5 - Back to Main Menu");
            Console.WriteLine("\n");
            try
            {
                Console.WriteLine("Choose Option ( 1 - 5 ) : ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddHourlyEmployee();
                        break;

                    case 2:
                        AddCommissionEmployee();
                        break;

                    case 3:
                        AddSalariedEmployee();
                        break;

                    case 4:
                        AddSalariedPlusCommissionEmployee();
                        break;

                    case 5:
                        menu();
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input Entered");
                        Console.WriteLine("\nPress Any Key to Continue....\n");
                        Console.ReadKey();
                        addMenu();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid Input Entered");
                Console.WriteLine("\nPress Any Key to Continue....\n");
                Console.ReadKey();
                addMenu();
            }

        }
        static void editMenu()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("1 - Edit Hourly Employee");
            Console.WriteLine("2 - Edit Commission Employee ");
            Console.WriteLine("3 - Edit Salaried Employee");
            Console.WriteLine("4 - Edit Salary Plus Commission Employee ");
            Console.WriteLine("5 - Back to Main Menu");
            Console.WriteLine("\n");
            try
            {
                Console.WriteLine("Choose Option ( 1 - 5 ) : ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        EditHourlyEmployee();
                        break;
                    case 2:
                        EditCommissionEmployee();
                        break;
                    case 3:
                        EditSalariedEmployee();
                        break;
                    case 4:
                        EditSalariedPlusCommissionEmployee();
                        break;

                    case 5:
                        menu();
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input Entered");
                        Console.WriteLine("\nPress Any Key to Continue....\n");
                        Console.ReadKey();
                        editMenu();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid Input Entered");
                Console.WriteLine("\nPress Any Key to Continue....\n");
                Console.ReadKey();
                editMenu();
            }
        }
        static void deleteMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("1 - delete Hourly Employee");
            Console.WriteLine("2 - delete Commission Employee ");
            Console.WriteLine("3 - delete Salaried Employee");
            Console.WriteLine("4 - delete Salary Plus Commission Employee ");
            Console.WriteLine("5 - Back to Main Menu");
            Console.WriteLine("\n");
            try
            {
                Console.WriteLine("Choose Option ( 1 - 5 ) : ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    deleteHourlyEmployee();
                }
                else if (option == 2)
                {
                    deleteCommissionEmployee();
                }
                else if (option == 3)
                {
                    deleteSalariedEmployee();
                }
                else if (option == 4)
                {
                    deleteSalariedPlusCommissionEmployee();
                }
                else if (option == 5)
                {
                    menu();
                }
                else
                {
                    Console.WriteLine("\nInvalid Input Entered");
                    Console.WriteLine("\nPress Any Key to continue\n");
                    Console.ReadKey();
                    deleteMenu();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInvalid Input Entered");
                Console.WriteLine("\nPress Any Key to continue\n");
                Console.ReadKey();
                deleteMenu();
            }
        }

        //Adding Hourly employees to the dictionary
        static void AddHourlyEmployee()
        {
            Console.WriteLine("\nAdding Hourly Employee\n");
            string EmployeeName;
            do
            {
                Console.Write("Enter Employee Name : ");
                EmployeeName = Console.ReadLine();
            } while (EmployeeName == null);
            Console.Write("Enter number of hours worked : ");
            double hoursWorked = double.Parse(Console.ReadLine());
            Console.Write("Enter hourly wage : ");
            double hourlyWage = double.Parse(Console.ReadLine());
            HourlyEmployee employee = new HourlyEmployee(id, EmployeeName, hoursWorked, hourlyWage);
            EmployeeName += id;
            id++;

            Employee.Add(EmployeeName, employee);
            Console.WriteLine("\nNew Employee Added\n");

            ViewHourlyEmployees();

            Console.WriteLine("Press Any Key to continue...");

            Console.ReadKey();
            addMenu();
        }

        //Viewing Hourly Employees
        static void ViewHourlyEmployees()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hourly Employees\n");

            bool isExist = false;
            foreach (var item in Employee)
            {
                if (item.Value.type == EmployeeType.HourlyEmployee)
                {
                    isExist = true;
                    break;
                }

            }
            if (isExist)
            {
                Console.WriteLine(String.Format("{0,10}|{1,10}|{2,12}|{3,11}|{4,15}| {5,20}| {6,16}|",
                    "Id", "Name", "Hours Worked", "Hourly Wage", "Gross Earnings"
                    , "Tax (20%)", "Net Earnings "));

                Console.WriteLine("----------------------------------------------------" +
                   "-----------------------------------------------------");

                foreach (var item in Employee)
                {
                    if (item.Value.type is EmployeeType.HourlyEmployee)
                    {
                        HourlyEmployee employee = (HourlyEmployee)item.Value;

                        Console.WriteLine(String.Format("{0,10}|{1,10}|{2,12}|{3,11}|{4,15}| {5,20}| {6,16}|",
                            $"{employee.EmployeeId}", employee.EmployeeName, employee.HoursWorked,
                            $"${employee.HourlyWage}", $"${employee.GrossEarnings}", $"${employee.Tax}",
                            $"${employee.NetEarnings}"));
                    }
                }
            }
            else
                Console.WriteLine("No Hourly Employees found");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Edit hourly employees based on id
        static void EditHourlyEmployee()
        {
            bool isExist = true;
            ViewHourlyEmployees();
            Console.WriteLine("Editing Hourly Employees");
            Console.WriteLine("Enter Id of employee you want to edit : ");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in Employee)
            {
                if (item.Value.EmployeeId == id && item.Value.type == EmployeeType.HourlyEmployee)
                {
                    HourlyEmployee employee = (HourlyEmployee)(item.Value);
                    isExist = false;

                    Console.WriteLine("Enter Employee Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter number of hours worked : ");
                    double hoursWorked = double.Parse(Console.ReadLine());
                    Console.Write("Enter hourly wage : ");
                    double hourlyWage = double.Parse(Console.ReadLine());
                    if (employee.EmployeeName != name)
                    {
                        Employee.Remove(item.Key);
                        employee.EmployeeName = name;
                        employee.HoursWorked = hoursWorked;
                        employee.HourlyWage = hourlyWage;
                        Employee.Add(name, employee);
                        break;

                    }
                    employee.EmployeeName = name;
                    employee.HoursWorked = hoursWorked;
                    employee.HourlyWage = hourlyWage;
                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Wrong Input Entered");
            }
            ViewHourlyEmployees();

            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
            editMenu();
        }


        //Delete Hourly Employees from the dictionary
        static void deleteHourlyEmployee()
        {
            string name = "";
            bool isExist = true;

            ViewHourlyEmployees();

            Console.WriteLine("\nDeleting Hourly Employees\n");
            Console.Write("Enter id of employee to want to delete : ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (var item in Employee)
            {
                if (item.Value.EmployeeId == option && item.Value.type == EmployeeType.HourlyEmployee)
                {
                    name = item.Key;
                    isExist = false;
                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Invalid Id Entered");
                Console.WriteLine("Press Any Key to continue");
                Console.ReadKey();
                deleteMenu();
            }

            else
            {
                Employee.Remove(name);
                Console.WriteLine("Employee with id " + option + " deleted\n");
                ViewHourlyEmployees();
                Console.WriteLine("\nPress Any Key to Continue....\n");
                Console.ReadKey();
                deleteMenu();
            }


        }

        //Adding Commission Employees to the dictionary
        static void AddCommissionEmployee()
        {

            Console.WriteLine("\nAdding Commission Employee\n");
            string EmployeeName;
            do
            {
                Console.Write("Enter Employee Name : ");
                EmployeeName = Console.ReadLine();
            } while (EmployeeName == null);
            Console.Write("Enter Gross Sales : ");
            double grossSales = double.Parse(Console.ReadLine());
            Console.Write("Enter Commission Rate : ");
            double rate = double.Parse(Console.ReadLine());
            CommissionEmployee employee1 = new CommissionEmployee(id,
                EmployeeName, grossSales, rate);
            EmployeeName += id;
            id++;
            Employee.Add(EmployeeName, employee1);
            Console.WriteLine("\nNew Employee Added\n");
            ViewCommissionEmployees();
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
            addMenu();


        }

        //Viewing Commission Employees
        static void ViewCommissionEmployees()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Commission Employees\n");

            bool isExist = false;
            foreach (var item in Employee)
            {
                if (item.Value.type == EmployeeType.CommissionEmployee)
                {
                    isExist = true;
                    break;
                }

            }
            if (isExist)
            {
                Console.WriteLine(String.Format("{0,10}|{1,10}|{2,12}|{3,15}|{4,19}" +
                    "| {5,18}| {6,19}|", "Id", "Name", "Gross Sales", "Commission Rate",
                    "Gross Earnings", "Tax (20%)", "Net Earnings "));

                Console.WriteLine("----------------------------------------------------" +
                    "-------------------------------------------------------------");

                foreach (var item in Employee)
                {
                    if (item.Value.type is EmployeeType.CommissionEmployee)
                    {
                        CommissionEmployee employee = (CommissionEmployee)item.Value;
                        Console.WriteLine(String.Format("{0,10}|{1,10}|{2,12}|{3,15}" +
                            "|{4,19}| {5,18}| {6,19}|", employee.EmployeeId, employee.EmployeeName,
                             $"${employee.GrossSales}", $"{employee.CommissionRate}%",
                            $"${employee.GrossEarnings}", $"${employee.Tax}", $"${employee.NetEarnings}"));

                    }

                }
            }
            else
                Console.WriteLine("No Commission Employees found");
            Console.ForegroundColor = ConsoleColor.White;

        }

        //Edit Commission Employees 
        static void EditCommissionEmployee()
        {
            bool isExist = true;
            ViewCommissionEmployees();
            Console.WriteLine("Editing Commission Employees");
            Console.WriteLine("Enter Id of employee you want to edit : ");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in Employee)
            {
                if (item.Value.EmployeeId == id && item.Value.type == EmployeeType.CommissionEmployee)
                {
                    CommissionEmployee employee = (CommissionEmployee)(item.Value);
                    isExist = false;
                    Console.WriteLine("Enter Employee Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Gross Sales : ");
                    double grossSales = double.Parse(Console.ReadLine());
                    Console.Write("Enter Commission Rate : ");
                    double rate = double.Parse(Console.ReadLine());
                    if (employee.EmployeeName != name)
                    {
                        Employee.Remove(item.Key);
                        employee.EmployeeName = name;
                        employee.GrossSales = grossSales;
                        employee.CommissionRate = rate;
                        Employee.Add(name, employee);
                        break;

                    }
                    employee.EmployeeName = name;
                    employee.GrossSales = grossSales;
                    employee.CommissionRate = rate;

                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Wrong Input Entered");
            }
            ViewCommissionEmployees();
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
            editMenu();
        }

        //Deleting Commission Employees
        static void deleteCommissionEmployee()
        {
            string name = "";
            bool isExist = true;

            ViewCommissionEmployees();

            Console.WriteLine("\nDeleting Commission Employees\n");
            Console.Write("Enter id of employee to want to delete : ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (var item in Employee)
            {
                if (item.Value.EmployeeId == option && item.Value.type == EmployeeType.CommissionEmployee)
                {
                    name = item.Key;
                    isExist = false;
                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Invalid Id Entered");
                Console.WriteLine("Press Any Key to continue");
                Console.ReadKey();
                deleteMenu();
            }

            else
            {
                Employee.Remove(name);
                Console.WriteLine("Employee with id " + option + " deleted\n");
                ViewCommissionEmployees();
                Console.WriteLine("\nPress Any Key to Continue....\n");
                Console.ReadKey();
                deleteMenu();
            }

        }

        //Adding Salaraied Employees
        static void AddSalariedEmployee()
        {
            Console.WriteLine("\nAdding Salaried Employee\n");
            string EmployeeName;
            do
            {
                Console.Write("Enter Employee Name : ");
                EmployeeName = Console.ReadLine();
            } while (EmployeeName == null);
            Console.Write("Enter Weekly Salary : ");
            double salary = double.Parse(Console.ReadLine());
            SalariedEmployee employee2 = new SalariedEmployee(id, EmployeeName, salary);
            EmployeeName += id;
            id++;
            Employee.Add(EmployeeName, employee2);
            Console.WriteLine("\nNew Employee Added\n");
            ViewSalariedEmployees();

            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
            addMenu();
        }

        //Viewing Salaried Employees
        static void ViewSalariedEmployees()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSalaried Employees\n");

            bool isExist = false;
            foreach (var item in Employee)
            {
                if (item.Value.type == EmployeeType.SalariedEmployee)
                {
                    isExist = true;
                    break;
                }

            }
            if (isExist)
            {

                Console.WriteLine(String.Format("{0,10}|{1,10}|{2,13}|{3,14}|{4,10}" +
                    "| {5,14}|", "Id", "Name", "Weekly Salary", "Gross Earnings",
                    "Tax (20%)", "Net Earnings "));

                Console.WriteLine("---------------------------------------------------" +
                    "--------------------------------------");

                foreach (var item in Employee)
                {
                    if (item.Value.type is EmployeeType.SalariedEmployee)
                    {
                        SalariedEmployee employee = (SalariedEmployee)item.Value;
                        Console.WriteLine(String.Format("{0,10}|{1,10}|{2,13}|{3,14}|{4,10}" +
                            "| {5,14}|", employee.EmployeeId, employee.EmployeeName,
                            $"${employee.WeekSalary}", $"${employee.GrossEarnings}", $"${employee.Tax}"
                            , $"${employee.NetEarnings}"));

                    }
                }
            }
            else
                Console.WriteLine("No Salaried Employees Found");

            Console.ForegroundColor = ConsoleColor.White;
        }

        //Deleting Salaried Employees
        static void deleteSalariedEmployee()
        {
            string name = "";
            bool isExist = true;

            ViewSalariedEmployees();

            Console.WriteLine("\nDeleting Salaried Employees\n");
            Console.Write("Enter id of employee to want to delete : ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (var item in Employee)
            {
                if (item.Value.EmployeeId == option && item.Value.type == EmployeeType.SalariedEmployee)
                {
                    name = item.Key;
                    isExist = false;
                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Invalid Id Entered");
                Console.WriteLine("Press Any Key to continue");
                Console.ReadKey();
                deleteMenu();
            }
            else
            {
                Employee.Remove(name);
                Console.WriteLine("Employee with id " + option + " deleted\n");
                ViewSalariedEmployees();
                Console.WriteLine("\nPress Any Key to Continue....\n");
                Console.ReadKey();
                deleteMenu();
            }

        }

        //Editing Salaried Employees
        static void EditSalariedEmployee()
        {
            bool isExist = true;
            ViewSalariedEmployees();
            Console.WriteLine("Editing Salaried Employees");
            Console.Write("Enter Id of employee you want to edit : ");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in Employee)
            {
                if (item.Value.EmployeeId == id && item.Value.type == EmployeeType.SalariedEmployee)
                {
                    SalariedEmployee employee = (SalariedEmployee)(item.Value);
                    isExist = false;
                    Console.Write("Enter Employee Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Weekly Salary : ");
                    double salary = double.Parse(Console.ReadLine());
                    if (employee.EmployeeName != name)
                    {
                        Employee.Remove(item.Key);
                        employee.EmployeeName = name;
                        employee.WeekSalary = salary;
                        Employee.Add(name, employee);
                        break;
                    }
                    employee.EmployeeName = name;
                    employee.WeekSalary = salary;
                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Wrong Input Entered");
            }
            ViewSalariedEmployees();
            Console.WriteLine("\nPress Any Key to continue...\n");
            Console.ReadKey();
            editMenu();
        }

        //Adding SalariedPlusCommission Employees
        static void AddSalariedPlusCommissionEmployee()
        {
            Console.WriteLine("\nAdding Salaried Plus Commission Employee\n");
            string EmployeeName;
            do
            {
                Console.Write("Enter Employee Name : ");
                EmployeeName = Console.ReadLine();
            } while (EmployeeName == null);
            Console.Write("Enter Gross Sales : ");
            double grossSales = double.Parse(Console.ReadLine());
            Console.Write("Enter Commission Rate : ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter Weekly Salary : ");
            double salary = double.Parse(Console.ReadLine());

            SalariedPlusCommissionEmployee employee3 = new SalariedPlusCommissionEmployee(id, EmployeeName, grossSales, rate, salary);
            EmployeeName += id;
            id++;
            Employee.Add(EmployeeName, employee3);
            Console.WriteLine("\nNew Employee Added\n");

            ViewSalariedPlusCommissionEmployee();

            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
            addMenu();

        }

        //Viewing SalariedPlusCommission Employees
        static void ViewSalariedPlusCommissionEmployee()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("SalariedPlusCommission Employees\n");
            bool isExist = false;
            foreach (var item in Employee)
            {
                if (item.Value.type == EmployeeType.SalariedPlusCommissionEmployee)
                {
                    isExist = true;
                    break;
                }

            }
            if (isExist)
            {
                Console.WriteLine(String.Format("{0,10}|{1,10}|{2,18}|{3,11}|{4,15}|" +
                    " {5,14}| {6,10}| {7,14}|", "Id", "Name", "Weekly Salary", "Gross Sales",
                    "Commission Rate", "Gross Earnings", "Tax (20%)", "Net Earnings "));

                Console.WriteLine("----------------------------------------------------" +
                   "-------------------------------------------------------------");

                foreach (var item in Employee)
                {
                    if (item.Value.type is EmployeeType.SalariedPlusCommissionEmployee)
                    {
                        SalariedPlusCommissionEmployee employee = (SalariedPlusCommissionEmployee)item.Value;
                        Console.WriteLine(String.Format("{0,10}|{1,10}|{2,18}|{3,11}|{4,15}|" +
                            " {5,14}| {6,10}| {7,14}|", employee.EmployeeId, employee.EmployeeName,
                            $"${employee.fixedWeekSalary}", $"${employee.GrossSales}", $"{employee.CommissionRate}%",

                        $"${employee.GrossEarnings}", $"${employee.Tax}", $"${employee.NetEarnings}"));
                    }
                }
            }
            else
                Console.WriteLine("No SalariedPlusCommission Employee found");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Editing SalariedPlusCommission Employees
        static void EditSalariedPlusCommissionEmployee()
        {
            bool isExist = true;
            ViewSalariedPlusCommissionEmployee();
            Console.WriteLine("Editing SalariedPlusCommission Employees");
            Console.Write("Enter Id of employee you want to edit : ");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in Employee)
            {
                if (item.Value.EmployeeId == id && item.Value.type == EmployeeType.SalariedPlusCommissionEmployee)
                {
                    SalariedPlusCommissionEmployee employee = (SalariedPlusCommissionEmployee)(item.Value);
                    isExist = false;
                    Console.Write("Enter Employee Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Gross Sales : ");
                    double grossSales = double.Parse(Console.ReadLine());
                    Console.Write("Enter Commission Rate : ");
                    double rate = double.Parse(Console.ReadLine());
                    Console.Write("Enter Weekly Salary : ");
                    double salary = double.Parse(Console.ReadLine());
                    if (employee.EmployeeName != name)
                    {
                        Employee.Remove(item.Key);
                        employee.EmployeeName = name;
                        employee.GrossSales = grossSales;
                        employee.CommissionRate = rate;
                        employee.fixedWeekSalary = salary;
                        Employee.Add(name, employee);
                        break;
                    }
                    employee.EmployeeName = name;
                    employee.GrossSales = grossSales;
                    employee.CommissionRate = rate;
                    employee.fixedWeekSalary = salary;
                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Wrong Input Entered");
            }
            ViewSalariedPlusCommissionEmployee();
            Console.WriteLine("Press Any Key to continue...");
            Console.ReadKey();
            editMenu();
        }

        //Deleting SalariedPlusCommission Employees
        static void deleteSalariedPlusCommissionEmployee()
        {
            string name = "";
            bool isExist = true;

            ViewSalariedPlusCommissionEmployee();

            Console.WriteLine("\nDeleting SalariedPlusCommission Employees\n");
            Console.Write("Enter id of employee to want to delete : ");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (var item in Employee)
            {
                if (item.Value.EmployeeId == option && item.Value.type == EmployeeType.SalariedPlusCommissionEmployee)
                {
                    name = item.Key;
                    isExist = false;
                    break;
                }
            }
            if (isExist)
            {
                Console.WriteLine("Invalid Id Entered");
                Console.WriteLine("Press Any Key to continue");
                Console.ReadKey();
                deleteMenu();
            }
            else
            {
                Employee.Remove(name);
                Console.WriteLine("Employee with id " + option + " deleted\n");
                ViewSalariedPlusCommissionEmployee();
                Console.WriteLine("\nPress Any Key to Continue....\n");
                Console.ReadKey();
                deleteMenu();
            }
        }


        //Searching All Emloyees
        static void SearchEmployees()
        {
            int a = 0;
            Console.WriteLine("Search Employees by name , Partial matches can fetch results.\n");
            Console.Write("Enter employee name to search : ");
            string search = Console.ReadLine();
            Console.WriteLine("\n");
            search = search.ToLower();
            List<Employee> listEmployee = new List<Employee>();

            //Searching Hourly Employees
            foreach (var item in Employee)
            {
                if (item.Key.ToLower().Contains(search))
                {
                    if (item.Value.type == EmployeeType.HourlyEmployee)
                    {
                        listEmployee.Add(item.Value);
                    }
                }
            }
            if (listEmployee.Count > 0)
            {
                a++;
                Console.WriteLine("Hourly Employees\n");
                Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,12}|{3,11}" +
                    "|{4,15}| {5,20}| {6,16}|", "Id", "Name", "Hours Worked",
                    "Hourly Wage", "Gross Earnings", "Tax (20%)", "Net Earnings "));

                foreach (var item in listEmployee)
                {
                    HourlyEmployee employee = (HourlyEmployee)item;

                    Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,12}|{3,11}" +
                            "|{4,15}| {5,20}| {6,16}|", $"{employee.EmployeeId}",
                            employee.EmployeeName, employee.HoursWorked,
                            $"${employee.HourlyWage}", $"${employee.GrossEarnings}",
                            $"${employee.Tax}", $"${employee.NetEarnings}"));
                }
                listEmployee.Clear();
            }
            //Searching Commission Employees
            foreach (var item in Employee)
            {
                if (item.Key.ToLower().Contains(search))
                {
                    if (item.Value.type == EmployeeType.CommissionEmployee)
                    {
                        listEmployee.Add(item.Value);
                    }
                }

            }
            if (listEmployee.Count > 0)
            {
                a++;
                Console.WriteLine("\nCommission Employees\n");
                Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,12}|{3,11}|{4,15}| {5,14}|" +
                    " {6,16}|", "Id", "Name", "Gross Sales", "Commission Rate", "Gross Earnings",
                    "Tax (20%)", "Net Earnings "));

                foreach (var item in listEmployee)
                {
                    CommissionEmployee employee = (CommissionEmployee)item;


                    Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,12}|{3,11}|{4,15}| {5,14}|" +
                        " {6,16}|", employee.EmployeeId, employee.EmployeeName,
                        $"${employee.CommissionRate}", $"${employee.GrossEarnings}",
                        $"${employee.GrossEarnings}", $"${employee.Tax}", $"${employee.NetEarnings}"));
                }
                listEmployee.Clear();
            }
            //Searching Salaried Employees
            foreach (var item in Employee)
            {
                if (item.Key.ToLower().Contains(search))
                {
                    if (item.Value.type == EmployeeType.SalariedEmployee)
                    {
                        listEmployee.Add(item.Value);
                    }
                }
            }
            if (listEmployee.Count > 0)
            {
                a++;
                Console.WriteLine("Salaried Employees\n");
                Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,13}|{3,14}|{4,10}| {5,14}|", "Id",
                    "Name", "Weekly Salary", "Gross Earnings", "Tax (20%)", "Net Earnings "));

                foreach (var item in listEmployee)
                {
                    SalariedEmployee employee = (SalariedEmployee)item;

                    Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,13}|{3,14}|{4,10}| {5,14}|",
                        employee.EmployeeId, employee.EmployeeName, $"${employee.WeekSalary}",
            $"${employee.GrossEarnings}", $"${employee.Tax}", $"${employee.NetEarnings}"));
                }
                listEmployee.Clear();
            }
            //Searching SalariedPlusCommission Employees
            foreach (var item in Employee)
            {
                if (item.Key.ToLower().Contains(search))
                {
                    if (item.Value.type == EmployeeType.SalariedPlusCommissionEmployee)
                    {
                        listEmployee.Add(item.Value);
                    }
                }
            }
            if (listEmployee.Count > 0)
            {
                a++;
                Console.WriteLine("SalariedPlusCommission Employees\n");
                Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,18}|{3,11}|{4,15}| {5,14}|" +
                    " {6,10}| {7,10}|", "Id", "Name", "Weekly Salary", "Gross Sales", "Commission Rate",
                    "Gross Earnings", "Tax (20%)", "Net Earnings "));
                foreach (var item in listEmployee)
                {
                    SalariedPlusCommissionEmployee employee = (SalariedPlusCommissionEmployee)item;


                    Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,18}|{3,11}|{4,15}| {5,14}| {6,10}|" +
                        " {7,10}|", employee.EmployeeId, employee.EmployeeName,
                        $"${employee.fixedWeekSalary}", $"${employee.GrossSales}", $"{employee.CommissionRate}%",
                    $"${employee.GrossEarnings}", $"${employee.Tax}", $"${employee.NetEarnings}"));
                }
                listEmployee.Clear();
            }
            if (a == 0)
            {
                Console.WriteLine("\nNo Result found");
            }
            Console.WriteLine("\nPress Any Key To continue...");
            Console.ReadKey();
            menu();
        }
    }
}