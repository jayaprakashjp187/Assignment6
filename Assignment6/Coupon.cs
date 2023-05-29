using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Coupon
    {
        public static void coup(int n)
        {
            int[] Coupon = new int[n];
            for (int i = 0; i < n; i++)
            {
                Coupon[i] = -1; 
            }

            Random random = new Random();
            int totalCoupons = 0;
            int distinctCoupons = 0;
            

            int upperLimit = (int)Math.Pow(10, n.ToString().Length);
           

            while (distinctCoupons < n)
            {
                int newCoupon = random.Next(0, upperLimit); // Generate new coupon number
                totalCoupons++;

                if (!Contains(Coupon, newCoupon))
                {
                    Coupon[distinctCoupons] = newCoupon;
                    distinctCoupons++;
                }
            }
            Console.WriteLine("Total random numbers needed to generate all distinct numbers: " + totalCoupons);

        }
    


        static bool Contains(int[] arr, int value)
        {
            foreach (int num in arr)
            {
                if (num == value)
                {
                    return true;
                }
            }
            return false;
        }

    }
}

