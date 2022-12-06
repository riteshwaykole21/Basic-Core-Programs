using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorepromblem
{
    public class Factors
    {
        public void Calculation()
        {
            Console.WriteLine("Enter the Number to Calculate Prime Factorization");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
