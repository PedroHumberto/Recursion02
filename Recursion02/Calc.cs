using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion02
{
    class Calc
    {
        public int fat(int n)
        {
            int res;
            if (n <= 1)
            {
                res = 1;
            }
            else
            {
                res = n * fat(n - 1);
            }
            return res;


        }
    }
}
