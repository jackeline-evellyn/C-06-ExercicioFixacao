using System;
using System.Globalization;
using System.Collections.Generic;

namespace _2_Listas
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int tamanho = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= tamanho; i++)
            {
                Console.WriteLine("Employee: #"+i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee (id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Enter the id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee employee = list.Find(x => x.Id == searchId);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentage);

            }
            else
            {
                Console.WriteLine("This Id does not exist");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
