using System;

namespace descending_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersQty = 0;
            int[] numbers;
            

            //obtain the lenght of the array

            Console.WriteLine("How many numbers you want to sort?");
            numbersQty = Convert.ToInt32(Console.ReadLine());
            numbers = new int[numbersQty];
            Console.Clear();

            //Load the array with the numbers to be sorted

            for (int i = 0; i < numbersQty; i++)
            {
                Console.WriteLine("Please Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Order algorithm

            for (int i = 0; i < numbersQty; i++)
            {
                for (int j = 0; j < numbersQty; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        //sortedNumbers[j] = numbers[i];
                        (numbers[i], numbers[j]) = (numbers[j], numbers[i]);

                    }
                }
            }

            //Console.Clear();
            Console.WriteLine("Numbers in descending order: ");

            // Show the ordered array
            for (int i = 0; i < numbersQty; i++)
            {
                
                Console.Write("{0} ", numbers[i]);
                
            }
            Console.ReadLine();
        }
    }
}
