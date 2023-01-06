namespace Nonstatic_Empwage
{
    public class CheckAttendence
    {
        public static int checkR(int Employeee)
        {

            Random random = new Random();
            int check = random.Next(3);
            if (Employeee == check)
            {
                Console.WriteLine("\n employee is present ");


            }
            else
            {
                Console.WriteLine("\n employee is absent");
            }
            return check;
        }
    }
}
