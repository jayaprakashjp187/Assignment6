namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FibonacciSeries");
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
            }
        }
    }
}