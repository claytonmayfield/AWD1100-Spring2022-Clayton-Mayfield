using System;
using static System.Console;

namespace CH5_p2_Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rows = " ";
            string columns = " ";
            Console.WriteLine("How many rows should the table have?");
            rows = ReadLine();
            Console.WriteLine("How many columns should the table have?");
            columns = ReadLine();
            string str = "";
            int row, column, val, colmax, rowmax = Int32.Parse(columns);
            row = 1;
            colmax =Int32.Parse(columns);
            rowmax =Int32.Parse(rows);
            Console.WriteLine("    Multiplication Table    ");
            Console.WriteLine("--------------------------");
            do
            {
                column = 1;
                do
                {
                    val = row * column;
                    Console.Write("\t" + val);
                    column += 1;
                }
                while (column <= colmax);
                Console.WriteLine();
                row += 1;
            }
            while (row <= rowmax);
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
    }

    
}

