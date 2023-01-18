using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate?  ");

            int numRolls = Convert.ToInt32(Console.ReadLine()); // converting user input to integer

            Console.Write("\n");

            //creating array to keep track of roll results
            int[] rollResults = {0,0,0,0,0,0,0,0,0,0,0,0,0};

            //initaliazing random number generator
            Random rnd = new Random();

            // loop for the dice rolls
            for (int x = 0; x < numRolls; x++)
            {
                int rollOne = rnd.Next(1, 7);

                int rollTwo = rnd.Next(1, 7);

                int rollTotal = rollOne + rollTwo;
               
                rollResults[rollTotal]++; //adding to the array storing roll totals

            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS \nEach \" * \" represents 1 % of the total number of rolls. \nTotal number of rolls = " + numRolls + ".\n");

            // loop to calculate the percentages
            for (int x = 2; x <= 12; x++) //starting at x = 2 to ignore impossible results in previous array
            {
                float rollPercentage = (float)rollResults[x] / (float)numRolls;
                int percentage = (int) (rollPercentage * 100);
                Console.Write(x + ": ");
                for (int y = 0; y < percentage; y++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");


        }

        
    }
}
