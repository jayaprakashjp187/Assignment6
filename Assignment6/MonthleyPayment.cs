using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class MonthleyPayment
    {
        public static double CalculateMonthleyPayment(double P, double Y, double R)
        {
            
            double n = 12 * Y;

           
            double r = R / (12 * 100);

          
            double payment = (P * r) / (1 - Math.Pow(1 + r, -n));

            return payment;
        }
    }
}
