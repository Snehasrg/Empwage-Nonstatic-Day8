namespace Nonstatic_Empwage
{
    public class CheckAttendence
    {
        public void check()
        {
            int Is_Full_Time = 1;
            Random R = new Random();
            int empCheck = R.Next(2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
