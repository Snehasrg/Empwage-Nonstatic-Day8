using System;

namespace Nonstatic_Empwage
{
    public class CondTotalNonstatic
    {
        public void CheckWage()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            const int MAX_HRS_IN_MONTH = 100;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpHrs = 0;
            int totalEmpWage = 0;
            int totalworkingdays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalworkingdays <= NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;

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
                totalEmpHrs += empHrs;
                 Console.WriteLine("Days:" + totalworkingdays + "Employee hours:" + empHrs);


            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage is" + totalEmpWage);
        }

    }
}
