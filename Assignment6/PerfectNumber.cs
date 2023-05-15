using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
     class PerfectNumber
    {
        public static void CheckingPerfectNumber(int num)
        {
            
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num%i == 0)
                {
                    sum += i;
                }
            }
            
            Console.WriteLine(sum);
            if(num==sum)
            {
                Console.WriteLine(num + "is a perfect number");
            }
            else
            {
                Console.WriteLine(num + "is not a perfect number");
            }
        }
    }
}
