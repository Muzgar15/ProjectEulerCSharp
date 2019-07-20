using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem19
    {
        public static int Solve()
        {
            int year = 1900;
            int month = 1;
            int day = 1;
            int counter = 0;
            // 0 represents monday
            int totalDays = 0;
            while (year != 2001)
            {
                day++;
                totalDays++;
                if (day >= 29)
                {
                    if (month == 2)
                    {
                        if (year % 4 == 0)
                        {
                            if (year % 100 == 0)
                            {
                                if (year % 400 == 0)
                                {
                                    if (day == 30)
                                    {
                                        day = 1;
                                        month++;
                                    }

                                }
                                else
                                {
                                    day = 1;
                                    month++;
                                }

                            }
                            else
                            {
                                if (day == 30)
                                {
                                    day = 1;
                                    month++;
                                }

                            }
                        }
                        else
                        {
                            if (day == 29)
                            {
                                day = 1;
                                month++;
                            }

                        }
                    }
                    else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        if (day == 32)
                        {
                            day = 1;
                            month++;
                        }
                    }
                    else
                    {
                        if (day == 31)
                        {
                            day = 1;
                            month++;
                        }
                    }
                }
                if (month == 13)
                {
                    month = 1;
                    year++;
                }

                if (day == 1)
                {
                    if (totalDays % 7 == 6)
                    {
                        if (year > 1900 && year < 2001)
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;

        }
    }
}

