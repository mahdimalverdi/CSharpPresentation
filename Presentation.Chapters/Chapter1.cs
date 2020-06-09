using Presentation.Chapters.Abstraction;
using System;

namespace Presentation.Chapters
{
    internal class Chapter1 : IChapter
    {
        static int maxIntValue = 2147483647;

        public void Execute()
        {
            Console.WriteLine("\nCHECKED output value is: {0}",
                                      CheckedMethod());
            Console.WriteLine("UNCHECKED output value is: {0}",
                              UncheckedMethod());
        }

        // Using a checked expression.
        private static int CheckedMethod()
        {
            int z = 0;
            try
            {
                // The following line raises an exception because it is checked.
                z = checked(maxIntValue + 10);
            }
            catch (System.OverflowException e)
            {
                // The following line displays information about the error.
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
            // The value of z is still 0.
            return z;
        }

        // Using an unchecked expression.
        private static int UncheckedMethod()
        {
            int z = 0;
            try
            {
                // The following calculation is unchecked and will not
                // raise an exception.
                z = maxIntValue + 10;
            }
            catch (System.OverflowException e)
            {
                // The following line will not be executed.
                Console.WriteLine("UNCHECKED and CAUGHT:  " + e.ToString());
            }
            // Because of the undetected overflow, the sum of 2147483647 + 10 is
            // returned as -2147483639.
            return z;
        }

    }
}