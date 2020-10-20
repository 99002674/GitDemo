using System;

namespace FirstNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DateTime.Now.Tostring());
            MathOpDelegate delAdd = Add;
            int result = delAdd(55,32);
            Console.WriteLine("Result of Add:\t" + result.Tostring());
        }
    }
}
