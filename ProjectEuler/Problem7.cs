namespace ProjectEuler
{
    class Problem7
    {
        public static long Solve()
        {
            int counter = 1;
            long num = 3;
            while(counter != 10001)
            {
                while (!Toolbox.IsPrime(num))
                {
                    num += 2;
                }
                counter++;
                num+=2;
            }
            return num-2;
        }
    }
}
