using System;

namespace LSPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManaged employee = new Employee();

            employee.FirstName = "Tim";
            employee.LastName = "Corey";
            employee.AssignManager(accountingVP);
            employee.CalculatePerHourRate(2);

            Console.WriteLine($"{ employee.FirstName }'s salary is ${ employee.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
