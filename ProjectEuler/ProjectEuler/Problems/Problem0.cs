using System;

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Print array elements with recursivity
    /// </summary>
    public sealed class Problem0
    {
        private static int[] options = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static int counter = 1;
        public int MyProperty { get; set; }

        internal static void PrintNumbers()
        {

            int arrayPosition = options.Length - counter;

            if (arrayPosition == 0)
            {
                Console.WriteLine(options[arrayPosition]);
                return;
            }

            int currentNumber = options[arrayPosition];

            Console.WriteLine(currentNumber);

            counter += 1;

            PrintNumbers();
        }
    }
}
