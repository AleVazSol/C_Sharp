using System;

namespace two_dimension_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array_a, array_b, array_c;
            int rows,cols;

            //Define the size of the arrays
            Console.WriteLine("Enter the number of rows that your arrays have:");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns that your arrays have:");
            cols = Convert.ToInt32(Console.ReadLine());

            array_a = new int[rows,cols];
            array_b = new int[rows,cols];
            array_c = new int[rows, cols];

            //Fill array a
            Console.Clear();
            Console.WriteLine("Fill the Firts array");

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++) 
                {
                    Console.Write("Enter value for [{0},{1}]: ",i,j);
                    array_a[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Fill array b
            Console.WriteLine("Fill the Second array");

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Enter value for [{0},{1}]: ", i, j);
                    array_b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // sum array a and array b
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                   array_c[i, j] = array_a[i,j] + array_b[i,j];
                }
            }

            //print all the arrays and the result of the sum
            Console.Clear();
            Console.WriteLine("Array A:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", array_a[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array B:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", array_b[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array A + B:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", array_c[i, j]);
                }
                Console.WriteLine();
            }
            
            //end of program
            Console.ReadLine();
        }
    }
}
