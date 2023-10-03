using System;
using System.Collections.Generic;
using Treino_POO5.Entities;


namespace Treino_POO5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int employees = int.Parse(Console.ReadLine());

            for (int i = 0; i < employees; i++) 
            {
                Console.WriteLine("Employee #" + i + " data: ");
                Console.Write("Outsourced (y/n): ");
                char yn = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valou per hour: ");
                double value = double.Parse(Console.ReadLine());
                if (yn == 'y')
                {
                    Console.Write("Additional charge: " );
                    double additionalcharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, value, additionalcharge));
                }else
                {
                    list.Add(new Employee(name, hours, value));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENT: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment());
            }
        }
    }
}