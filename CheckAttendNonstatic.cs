namespace Nonstatic_Empwage
{
    public class CheckAttendNonstatic
    {
        public  void checkAttendence()
        {
            int FULL_TIME = 1;

            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
