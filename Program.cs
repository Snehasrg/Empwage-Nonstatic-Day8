using Nonstatic_Empwage;

namespace NonstaticEmpWage
{
    class program
    {
        public static void Main(String[] args)
        {
           // Console.WriteLine("Welcome to Employee Wage Computation by Non static method");
           
           // CheckAttendence obj = new CheckAttendence();
           // obj.check();

           //  DailyEmpWageNonstatic obj = new DailyEmpWageNonstatic();
            // obj.CheckWage();

            // ParttimeEmpWageNonstatic obj = new ParttimeEmpWageNonstatic();
             //obj.CheckWage();

             //SwitchcaseNonstatic obj = new SwitchcaseNonstatic();
             //obj.CheckWage();

           // EmpMonthWageNonstatic obj = new EmpMonthWageNonstatic();
            //obj.CheckWage();

          //  CondTotalNonstatic obj = new CondTotalNonstatic();
           // obj.CheckWage();

            RefactorCode obj= new RefactorCode();
            obj.Cal_Wage(20, 100);
        }
    }
}
