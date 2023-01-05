namespace Nonstatic_Empwage
{
    public class ParttimeEmpWageNonstatic
    {
        public void CheckWage()
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else if (empCheck == PART_TIME)
            {
                Console.WriteLine("Employee is present Part time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is" + empWage);

        }

    }
}
