namespace Nonstatic_Empwage
{
    public class SwitchcaseNonstatic
    {
        public void CheckWage()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {


                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)

                {

                    case FULL_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    case 0:
                        empHrs = 0;
                        break;
                }


                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;

                Console.WriteLine("Employee Wage is" + empWage);
            }
            Console.WriteLine("Total Employee Wage is" + totalEmpWage);
        }

    }
}
