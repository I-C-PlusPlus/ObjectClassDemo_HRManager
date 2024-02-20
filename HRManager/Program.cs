//Dayan Turino dturino@cnm.edu
//Object Class Demo

namespace HRManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";

            HourlyEmployee hourEmp = new HourlyEmployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.00M;

            Employee emp2 = hourEmp; //Polymorphism
            //int num = "Blah"; //This will not compile

            Console.WriteLine(emp.PaySummary);
            Console.WriteLine($"emp.GeHashCode(): {emp.GetHashCode()}");
            Console.WriteLine($"emp.GeType(): {emp.GetType()}");
            Console.WriteLine($"emo.ToString: {emp.ToString()}");
            Console.WriteLine($"emp: {emp}");

            Console.WriteLine(hourEmp.PaySummary);
            Console.WriteLine($"hourEmp.GetHashCode(): {hourEmp.GetHashCode()}");
            Console.WriteLine($"hourEmp.GetType(): {hourEmp.GetType()}");
            Console.WriteLine($"hourEmp.ToString(): {hourEmp.ToString()}");
            Console.WriteLine($"hourEmp: {hourEmp}");


            //Boxing
            Object athing = emp;
            Console.WriteLine($"hourEmp: {athing}");

            //Unboxing
            if (athing is HourlyEmployee)
            {
                HourlyEmployee unboxedEmp =(HourlyEmployee)athing;
                Console.WriteLine($"unboxedEmp hourly rate: {unboxedEmp.HourlyRate}");
            }
            else if (athing is Employee) 

            {
                Employee unboxedEmp=(Employee)athing;
                Console.WriteLine($"unboxedEmp hourly rate: {unboxedEmp.FirstName} {unboxedEmp.LastName} does not have a payment method yet.");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
