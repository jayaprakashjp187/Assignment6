namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumberProgram\n3.primenumber program\n4.ReverseNumber\n5.CouponNumber\n6.StopWatch");
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
                 case 6:
                    Console.WriteLine("welcome to the Stopwatch Program");
                    StopWatch.CheckingStopWatch();
                    break;
                case 7:
                    Console.WriteLine("welcome to the Vending Machine program");
                    Console.WriteLine("Enter hoe much amount of change u want");
                    n = Convert.ToInt32(Console.ReadLine());
                    VendingMachine.Vmac(n);
                    break;
                case 8:
                  
                    Console.WriteLine("Enter the date: ");
                    int day = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the month (in Number): ");
                    int month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the year: ");
                    int year = Convert.ToInt32(Console.ReadLine());

                    int dayOfWeek = DayOfWeek.DayWeek(day, month, year);
                    string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                    string dayName = days[dayOfWeek]; 

                    Console.WriteLine("The day of the week on the given date (" + day + "." + month + "." + year + ")  " + dayOfWeek + "  is " + dayName );
                   
                    break;
                 case 9:
                    Console.WriteLine("welcome to the Temparature Conversion program");
                    Console.WriteLine("Please select Conversion From\n1.Celsius to Fahrenheit\n2.Fahrenheit to Celsius");
                    n = Convert.ToInt32(Console.ReadLine());
                    double temp;
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("You have selected\t1.\tCelsius to Fahrenheit\nPlease Enter the Temparature in Celisus:");
                            temp = Convert.ToDouble(Console.ReadLine()); 
                            Temparature.CelsiusToFahrenheit(temp);
                            break;

                        case 2:
                            Console.WriteLine("You have selected\t2.\tFahrenheit to Celsius\nPlease Enter the Temparature in Fahrenheit:");
                            temp = Convert.ToDouble(Console.ReadLine()); 
                            Temparature.FahrenheitToCelsius(temp);
                            break;

                        default:
                            Console.WriteLine("Please select a  1 or 2 ");
                            break;
                    }
        
                    break;








            }
        }
    }
}
