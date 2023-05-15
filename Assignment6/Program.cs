namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FibonacciSeries\n2.PerfectNumberProgram");
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
            }
        }
    }
}