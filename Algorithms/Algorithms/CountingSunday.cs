using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class CountingSunday
    {
        List<int> leapYearList = new List<int>();

        int[] monthNormalYear = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        int[] monthLeapYear = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public int Main()
        {
            //int day = dt.DayOfYear(1,1,1);

            int beginDay = 6;

            int totalSunday = 0;

            for (int currentYear = 1901; currentYear < 2001; currentYear++)
            {
                if (currentYear % 4 == 0 || currentYear % 400 == 0)
                {
                    for (int currentMonth = 1; currentMonth < 13; currentMonth++)
                    {
                        while (beginDay <= monthLeapYear[currentMonth - 1])
                        {
                            beginDay = beginDay + 7;
                        }

                        beginDay = beginDay - monthLeapYear[currentMonth - 1];

                        if (beginDay == 1)
                        {
                            totalSunday = totalSunday + 1;
                        }
                    }
                }
                else
                {
                    for (int currentMonth = 1; currentMonth < 13; currentMonth++)
                    {
                        while (beginDay <= monthLeapYear[currentMonth - 1])
                        {
                            beginDay = beginDay + 7;
                        }

                        beginDay = beginDay - monthLeapYear[currentMonth - 1];

                        if (beginDay == 1)
                        {
                            totalSunday = totalSunday + 1;
                        }

                    }
                }
            }

            return totalSunday;
        }  
    }
}
