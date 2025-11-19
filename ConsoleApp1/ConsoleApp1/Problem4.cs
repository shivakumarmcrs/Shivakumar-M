using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Problem4
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 8, 9, 12, 46, 76, 82, 15, 20, 30 };
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 1; i <= 9; i++)
            {
                result[i] = 0;

            }
            foreach (int num in numbers)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (num % i == 0)
                    {
                        result[i]++;
                    }
                }
            }
            Console.WriteLine("Output : ");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

    }
}
