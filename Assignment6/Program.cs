namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumberProgram\n3.primenumber program\n4.ReverseNumber");
            Console.WriteLine("please choose what program u want");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("welcome to the fibonacci series program");
                    Console.WriteLine("please enter how many series u want");
                    int series = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.CheckingFibonacciSeries(series);
                    break;
                case 2:
                    Console.WriteLine("welcome to the perfect number program");
                    Console.WriteLine("please enter any number for checking perfect number or not");
                    int perfectNumber=Convert.ToInt32(Console.ReadLine());
                    PerfectNumber.CheckingPerfectNumber(perfectNumber);
                    break;
                case 3:
                    Console.WriteLine("welcome to the prime number program");
                   
                    
                    Console.WriteLine("enter the number checking whether the number is prime or not");
                    int n = Convert.ToInt32(Console.ReadLine());
                    PrimeNumber k = new PrimeNumber();
                    k.checkingPrimeNumber(n);
                    break;
                case 4:

                    Console.WriteLine("welcome to the reverse program");
                    Console.WriteLine("enter the number for checking either reverse or not");
                    int num = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber j = new ReverseNumber();
                    j.checkingReverseNumber(num);
                    break;
                case 5:
                    Console.WriteLine("welcome to the coupon code program");
                    Console.WriteLine("Enter How many Distinct Coupons u want ");
                    
                    int DistinctCoupon = Convert.ToInt32(Console.ReadLine());
                    Coupon.coup(DistinctCoupon);
                   

                   break;


            }
        }
    }
}