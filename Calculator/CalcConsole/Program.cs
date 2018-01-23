using System;

namespace CalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = args[0];
            //Console.WriteLine("Chislo a");
            var a = Convert.ToInt32(args[1]);
           // Console.WriteLine("Chislo b");
            var b = Convert.ToInt32(args[2]);
            //Console.WriteLine("Operation");
            
            //Console.WriteLine("Hello World!");
            if (c == "sum")
            {
                var result = a + b;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
