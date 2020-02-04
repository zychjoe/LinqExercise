using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            // List of employees
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their first name starts with C OR S.
            //Order this in acesnding order by FirstName.

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.

            //Print the Sum and Average of the employees YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35

            //Add an employee to the end of the list without using employees.Add()

            //Print the Sum and average of numbers

            //Order numbers in ascending order and decsending order. Print each to console.

            //Print to the console only the numbers greater than 6

            //Order numbers in any order but only print 4 **foreach loop only!**
            Console.WriteLine();

            Console.ReadLine();
        }

        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
    }
}
