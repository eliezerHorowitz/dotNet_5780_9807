using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Progrem
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arrayA = new int[20];
            int[] arrayB = new int[20];
            int[] arrayC = new int[20];

            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayA[i] = random.Next(18, 123);
                arrayB[i] = random.Next(18, 123);
            }
            foreach (int n in arrayA)
            {
                Console.Write("{0,-3}", n);
                Console.Write(" ");
            }
            Console.WriteLine();
            foreach (int n in arrayB)
            {
                Console.Write("{0,-3}", n);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                arrayC[i] = Math.Abs(arrayA[i] - arrayB[i]);

            }
            foreach (int n in arrayC)
            {
                Console.Write("{0,-3}", n);
                Console.Write(" ");
            }
            Console.ReadKey();

        }

    }
}
    
