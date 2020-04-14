using System;
using System.Collections.Generic;
using System.Text;

namespace assgn_2_Nicklkic
{
    static class StaticCircle
    {
        public static double radius { set; get; }

        public static double CalculateArea(float radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
