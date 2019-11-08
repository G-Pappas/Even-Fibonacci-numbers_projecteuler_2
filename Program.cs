﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Each new term in the Fibonacci sequence is generated by adding the previous 
//two terms.By starting with 1 and 2, the first 10 terms will be:

//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

//By considering the terms in the Fibonacci sequence whose values do not exceed four million,
//find the sum of the even-valued terms.

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;  
            int fib1 = 0; 
            int fib2 = 1; 
            int fib = 0;  

            while (fib < 4000000) 
            {
                if (fib % 2 == 0) 
                {
                    sum = sum + fib; 
                }
                fib = fib1 + fib2; 
                fib2 = fib1;                
                fib1 = fib;

            }

            Console.WriteLine(sum);
            Console.Read();

        }
    }
}
