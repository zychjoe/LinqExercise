using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers

            void Printer(IEnumerable<int> arr)
            {
                foreach(int i in arr)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("**************Here's the list:****************");
            Printer(numbers);
            Console.WriteLine("**************And now the sum:****************");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("****************And average:******************");
            Console.WriteLine(numbers.Average());

            //Order numbers in ascending order and decsending order. Print each to console.

            Console.WriteLine("**************Ascending Order:****************");
            var ascNumbers = numbers.OrderBy(x => x);
            Printer(ascNumbers);
            Console.WriteLine("*************Descending Order:****************");
            var descNumbers = numbers.OrderByDescending(x => x);
            Printer(descNumbers);

            //Print to the console only the numbers greater than 6
            Console.WriteLine("*******Or just the ones higher than 6:********");
            var over6 = numbers.Where(x => x > 6);
            Printer(over6);

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("**********Here's just four of them:***********");
            Printer(numbers.Take(4));
            //Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("**And now to replace index 4 w/ my \"age\":***");
            numbers[4] = 22;
            Printer(numbers.OrderByDescending(x => x));

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            Console.WriteLine("&&AND NOW FOR SOMETHING COMPLETELY DIFFERENT&&");


            Console.WriteLine("************A list of employees:**************");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.FullName}, Age: {employee.Age}");
            }

            Console.WriteLine("****But only the full names of those whose****");
            Console.WriteLine("******first name's start with \"C\" or \"S\"******");
            Console.WriteLine("********alphabetically by first name:*********");

            var cAndS = employees.Where(e => e.FirstName[0] == 'C' || e.FirstName[0] == 'S').OrderBy(x => x.FirstName);
            foreach (Employee emp in cAndS)
            {
                Console.WriteLine(emp.FullName);
            }



            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            Console.WriteLine("**********Just those older than 26:***********");
            var ovr26 = employees.Where(emp => emp.Age > 26).OrderBy(e => e.Age).ThenBy(em => em.FirstName);
            foreach (Employee employee in ovr26)
            {
                Console.WriteLine($"Name: {employee.FullName}, Age: {employee.Age}");
            }

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("And this is crazy but just trust me, it's right:");
            var specific = employees.Where(e => e.YearsOfExperience <= 10 && e.Age > 35);
            var specificYOE = specific.Select(e => e.YearsOfExperience);
            Console.WriteLine(specificYOE.Sum());
            Console.WriteLine(specificYOE.Average());

            //Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("And let's throw my boy Timmy in there and call it a day!!");
            var addTimmy = employees.Append(new Employee("Timothy", "Timmerson", 102, 95));

            foreach (Employee employee in addTimmy)
            {
                Console.WriteLine($"Name: {employee.FullName}, Age: {employee.Age}");
            }
        }

        #region CreateEmployeesMethod
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
        #endregion
    }
}
