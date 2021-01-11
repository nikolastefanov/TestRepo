using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Sum_Digits
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num!=0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;                
            }
            Console.WriteLine(sum);
        }
    }
}
