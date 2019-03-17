using System;

namespace SingleLineArray
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Initialize a single line an array with the following values: 1, 1, 2, 3, 5, 8. 
            int[] singleLineArray = new int[] { 1, 1, 2, 3, 5, 8 };

            // TODO: Loop through the array using foreach and print out each value on its own line.
            foreach (int number in singleLineArray)
            {
                Console.WriteLine(number);
                
            }
            Console.ReadLine();

        }
    }
}
