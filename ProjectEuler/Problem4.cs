namespace ProjectEuler
{
    class Problem4
    {
        public static int Solve()
        {
            int mult = 0;
            int largest = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    mult = i * j;
                    if (Toolbox.IsPalindrome(mult))
                    {
                        if (mult > largest)
                        {
                            largest = mult;
                        }
                    }
                }
            }
            return largest;
        }
    }
}
