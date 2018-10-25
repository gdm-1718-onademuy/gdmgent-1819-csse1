using System;

namespace opdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            // TABLES OF MULTIPLICATION
            Console.WriteLine("Tables of Multiplication");

            int tableOf = 7;
            for(int i = 0; i <= tableOf; i++) {
                int multiplication = tableOf * i;
                Console.WriteLine("Table of "+ tableOf + " - " + multiplication);
            }

            // FACULTY OF A NUMBER
            int number = 7;
            int factorial(int facultyOf)
            {
            return (facultyOf == 1 || facultyOf == 0) ? 1 : factorial(facultyOf - 1) * facultyOf;
            }
            Console.WriteLine("Faculty of: " + number + " = " + factorial(number));

            // FIBONACCI SEQUENCE
            Console.WriteLine("Fibonacci Sequence");

            int num1 = 0, num2 = 1;
            int seq_length = 20;

            for(int i = 0; i < seq_length; i++)
            {
                int seq = num1 + num2;
                num1 = num2;
                num2 = seq;
                Console.Write(seq + "  ");
            }
        }
    }
}
