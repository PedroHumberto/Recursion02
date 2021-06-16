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
