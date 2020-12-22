using System;
using System.Collections.Generic;

namespace OCPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new PersonModel { FirstName = "Sue", LastName = "Storm", TypeOfEmployee = EmployeeType.Manager },
                new PersonModel { FirstName = "Nancy", LastName = "Roman", TypeOfEmployee = EmployeeType.Executive }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{ employee.FirstName } { employee.LastName }: { employee.EmailAddress } IsManager: { employee.IsManager } IsExecutive: { employee.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
