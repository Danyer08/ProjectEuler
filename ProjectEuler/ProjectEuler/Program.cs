using ProjectEuler.Problems;
using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    sealed class Program
    {
        private static Dictionary<int, Action> _optionsDictionary;

        private static void InitializeDictionary()
        {
            _optionsDictionary = new Dictionary<int, Action>
            {
                {0, Problem0.PrintNumbers },
                {1, Problem1.SayHello }
            };
        }

        static void Main()
        {
            InitializeDictionary();

            Console.WriteLine("Select an option");

            int option = Convert.ToInt32(Console.ReadLine());

            _optionsDictionary[option]();

            Console.ReadKey();
        }
    }
}
