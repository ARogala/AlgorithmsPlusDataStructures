﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class Recursion
    {
        public void calculate(int n)
        {
            if (n > 0)
            {
                calculate(n - 1);
                int k = n * n;
                Console.WriteLine(k);
            }
        }

        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            r.calculate(4);
            Console.ReadKey();
        }
    }
}
