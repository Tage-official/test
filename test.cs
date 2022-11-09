using System;
namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            double c = double.Parse(Console.ReadLine());
            double summ = a + b + c;
            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, summ);
        }
    }
}