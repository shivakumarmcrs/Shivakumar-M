using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Problem3
    {
        static void Main()
        {
            Console.WriteLine("Enter a number :");
            int a = Convert.ToInt32(Console.ReadLine());

            int n = (a % 2 == 0) ? a - 1 : a;

            for (int i = 1; i <= n; i++)
            {
                int oddnumber = (2 * i) - 1;
                Console.Write(oddnumber);

                if (i < a)
                {
                    Console.Write(",");
                }
            }

        }
    }
}
