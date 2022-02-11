using System;
using System.Linq;
using static System.Console;

namespace HOT4_2
{
    internal class Program
    {
        static int MAXENTRYS = 5;
        static int lowestNumber = 0;
        static int highestNumber = 1000000;
        static void Main(string[] args)
        {
            string[] firstNames = new string[MAXENTRYS];
            string[] lastNames = new string[MAXENTRYS];
            string[] department = new string[MAXENTRYS];
            int[] salary = new int[MAXENTRYS];
            //int[] high = new int[MAXENTRYS];
            //int[] low = new int[MAXENTRYS];
           
            for (int lcv = 0; lcv < MAXENTRYS; ++lcv)
            {
                firstNames[lcv] = inputFirstName(lcv);
               lastNames[lcv] = inputLastName(lcv);
                department[lcv] = inputDepartment(lcv);
                salary[lcv] = inputSalary(lcv);
                

            }
            OutInfo(firstNames, lastNames, salary, department);
            ReadLine();
           
        }
        static void OutInfo(string[] firstName, string[] lastNames, int[] salarys, string[] department)
        {  Clear();
            for (int lcv = 0; lcv < MAXENTRYS; ++lcv)
            {
                WriteLine("Frist name: " + firstName[lcv]);
                WriteLine("last name: " +lastNames[lcv]);
                WriteLine("department name: " + department[lcv]);
                WriteLine("Salary: "+ salarys[lcv].ToString() + "\n");

            }
             WriteLine("Highest Salary:" + salarys.Max().ToString("c"));
            WriteLine("lowest Salary:" + salarys.Min().ToString("c"));
        }
       
        static string inputFirstName(int lcv)
        {
            string first;

            Write("\nInput First name #" + " " + (lcv + 1).ToString() + "\t\t");
            first = ReadLine().Trim();
            
            while (first == "")
            {
                Write("\n Enter a frist name:" + " ");
                first = ReadLine().Trim();
            }
            return first;

        }
        static string inputLastName(int lcv)
        {
            string last;

            Write("Input last name #" + " " + (lcv + 1).ToString() + "\t\t");
            last = ReadLine().Trim();

            while (last == "")
            {
                Write("\n Enter a last name:" + " ");
                last
                    = ReadLine().Trim();
            }
            return last;

        }
        static string inputDepartment(int lcv)
        {
            string department;

            Write("Input the department name #" + " " + (lcv + 1).ToString() + "\t\t");
            department = ReadLine().Trim();

            while (department == "")
            {
                Write("\n Enter a department Name:" + " ");
                department
                    = ReadLine().Trim();
            }
            return department;

        }
        static int inputSalary(int lcv)
        {
            bool result;
            int salary;
         

            
                Write("Input the salary amount #" + " " + (lcv + 1).ToString() + "\t\t");
                result = int.TryParse(ReadLine(), out salary);



            
            while ( !result)
            {
                Write("\nPlease enter a salary:" + " ");
                result = int.TryParse(ReadLine(), out salary);
            }
            if (salary < lowestNumber || salary > highestNumber)
            {
                Write("\nPlease enter a diffent salary:" + " ");
                result = int.TryParse(ReadLine(), out salary);
                if (salary < lowestNumber || salary > highestNumber)
                {
                    Write("\nPlease enter a diffent salary:" + " ");
                    result = int.TryParse(ReadLine(), out salary);
                }
            }
            return salary;
                
        }
       
       
    }
    
}
