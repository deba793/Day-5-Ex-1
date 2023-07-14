using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees:");
            int numEmployees = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of working days for each employee:");
            int numDays = int.Parse(Console.ReadLine());


            int[][] salaries = new int[numEmployees][];


            for (int i = 0; i < numEmployees; i++)
            {
                salaries[i] = new int[numDays];
                Console.WriteLine($"Enter salaries for employee {i + 1}:");
                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"Day {j + 1}: ");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Weekly Salaries:");
            for (int i = 0; i < numEmployees; i++)
            {
                int weeklySalary = 0;
                for (int j = 0; j < numDays; j++)
                {
                    weeklySalary += salaries[i][j];
                }
                Console.WriteLine($"Employee {i + 1}: {weeklySalary}");
            }
        }
    }
}