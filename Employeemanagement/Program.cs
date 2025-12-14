namespace Employeemanagement
{
    internal class Program
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_IN_MONTH = 100;
        public static int ComputeEmpWage()
        {
            //VARIABLES
            int empHrs = 0;
            int totalworkinghours = 0;
            int totalEmpWage = 0;
            Random random = new Random();
            //Computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS && totalworkinghours < MAX_IN_MONTH; day++)
            {
                int empCheck = random.Next(0,3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs += 4;
                        totalworkinghours += 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs += 8;
                        totalworkinghours += 8;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
                
            }
            
            totalEmpWage = empHrs * EMP_RATE_PER_HOUR;

            return totalEmpWage;
            
        }

        public static void Main(string[] args)
        {
            int wage = ComputeEmpWage();
            Console.WriteLine(wage);
        }
    }

}
