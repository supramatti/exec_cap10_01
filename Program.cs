using ConsoleApp10_1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> worker = new List<Employee>(n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Employee {i}# data: ");
                Console.Write("Outsourced (y/n)? ");
                char a = char.Parse(Console.ReadLine());
                if (a != 'y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valueperhour = double.Parse(Console.ReadLine());
                    Employee w = new Employee(name, hours, valueperhour);
                    worker.Add(w);
                    w.Payment();
                }
               else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valueperhour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double additionalcharge = double.Parse(Console.ReadLine());
                    OutsourcedEmployee w = new OutsourcedEmployee(name, hours, valueperhour, additionalcharge);
                    worker.Add(w);
                    w.Payment();
                }
            }
            Console.WriteLine("PAYMENTS:");
            foreach (Employee obj in worker)
            {
                Console.WriteLine(obj.Name + " - $ " + obj.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
