using System;

namespace ProjetCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabM = new int[2, 3];

            tabM[0, 0] = 9;
            tabM[0, 1] = 11;
            tabM[0, 2] = 8;

            tabM[1, 0] = 2;
            tabM[1, 1] = 44;
            tabM[1, 2] = 67;

//            Console.WriteLine(tabM.Length);
//            Console.WriteLine(tabM[0, 1]);
//            Console.WriteLine(tabM[1, 2]);


            string[,] tabM2 = new string[3, 2]
            {
                {
                    "un",
                    "deux"
                },
                {
                    "trois",
                    "quatre"
                },
                {
                    "cinq",
                    "six"
                }
            };

//            int[][] TabEscalier = new int[3][];
//
//            TabEscalier[0] = new int[0];
//            TabEscalier[1] = new int[6] {1, 2, 3, 4, 5, 6};
//            TabEscalier[2] = new int[] {1, 2, 3};
//
//            Console.WriteLine(TabEscalier.Length);
//            Console.WriteLine(TabEscalier[1][3]);
//            Console.WriteLine(TabEscalier[2][2]);

            int[][] TabEscalier2 =
            {
                new int[] {1, 2, 3, 4, 5},
                new int[] {1, 12, 33},
                new int[] {5, 55, 555}
            };

            Console.WriteLine(TabEscalier2.Length);
            Console.WriteLine(TabEscalier2[1][2]);
            Console.WriteLine(TabEscalier2[2][2]);
        }
    }
}
