using System;

namespace Prestige.Biz
{
    class Program
    {
        /* Constant*/                               /* Read-only */
        // Compile-time constant                    Runtime constant
        // Assigned on declaration                  Assigned on declaration or constructor
        // Only a number, string or boolean         Any data type
        // Always static                            Optionally static

        public const int ConstantNumber = 100;
        public static readonly int ReadOnlyNumber = 0;

        static Program()
        {
            ReadOnlyNumber = 10;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ConstantNumber);
            Console.WriteLine(ReadOnlyNumber);
            Console.ReadKey();
        }
    }
}
