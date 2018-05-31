using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSol
{
    class Program
    {
        static void Main(string[] args)
        {
            #region - Main Variables
            int count;
            string name;
            int number;
            #endregion

            Console.WriteLine("How many employees would you like to add?");
            count = Convert.ToInt32(Console.ReadLine());

            List<Employee> emp = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("What is the name?");
                name = Console.ReadLine();

                Console.WriteLine("What is the employee number?");
                number = Convert.ToInt32(Console.ReadLine());

                Employee empEmp = new Employee(name, number);

                emp.Add(empEmp);

            }

            for (int j = 0; j < emp.Count; j++)
            {
                Console.WriteLine($"The employee name is {emp[j].name} and the employee number is {emp[j].number}");

            }
        }
    }

    struct Employee
    {

        public string name;
        public int number;

        public Employee(string eName, int eNumber)
        {
            this.name = eName;
            this.number = eNumber;

        }
    }
}
