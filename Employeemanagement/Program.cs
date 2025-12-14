namespace Employeemanagement
{
    internal class ComputeEmpWages
    {


        int total_emp_wages = 0;
        private string company;
        private int emp_per_hours;
        private int Max_working_hours;
        private int Max_emp_working_days;
        public ComputeEmpWages(string company, int emp_per_hours, int Max_working_hours, int Max_emp_working_days)
        {
            this.emp_per_hours = emp_per_hours;
            this.Max_working_hours = Max_working_hours;
            this.Max_emp_working_days = Max_emp_working_days;
            this.company = company;
        }
        public void calculateWages()
        {
            int empHours = 0;
            int total_emp_working_days = 0;
            int total_emp_working_hours = 0;
            while (total_emp_working_hours < Max_working_hours && total_emp_working_days < Max_emp_working_days)
            {

                Random random = new Random();
                int empAttendence = random.Next(0, 3);
                switch (empAttendence)
                {
                    case 1:
                        empHours = 4;
                        break;
                    case 2:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                total_emp_working_days++;
                total_emp_working_hours += empHours;
                Console.WriteLine($"Days: {total_emp_working_days} Employee Hours: {total_emp_working_hours} Present {empHours}");
            }
            total_emp_wages = total_emp_working_hours * emp_per_hours;
            Console.WriteLine($"Toatl Employee Wage for company {company} is : {total_emp_wages}$");
        }
        public string toString()
        {
            return "Ttal Employee Wage for Company : " + this.company + " is: " + this.total_emp_wages + "$";
        }

        static void Main(string[] args)
        {
            ComputeEmpWages Bridgelabz = new ComputeEmpWages("Bridgelabz", 20, 100, 20);
            Bridgelabz.calculateWages();
            Console.WriteLine(Bridgelabz.toString());
            ComputeEmpWages Google = new ComputeEmpWages("Google", 50, 100, 20);
            Google.calculateWages();
            Console.WriteLine(Google.toString());
        }
    }

}
