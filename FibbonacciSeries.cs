﻿namespace LogicProgrammingProblems
{
    public class FibbonacciSeries
    {
        public static void DisplayFibonacciSeries()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("Enter the number of Elements");
            number=Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for(i=2; i<number;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
