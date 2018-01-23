using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> log = new List<string>();

            CalculateComand comand = new CalculateComand();
            var calculate = new Calculate();

            Console.WriteLine("Введите команду вида Оператор Число1 Число2,\n " +
                                    "для получения доступных операторов введите: !help,\n " +
                                    "для вывода последних операций: !last");

            
            while(true)
            {
                string stroke = "";
                stroke = Console.ReadLine();
                
                switch (stroke)
                {
                    case "!help":
                        {
                            string[] commands = new string[]
                           {
                                "Список команд",
                                "1. !help список команд",
                                "2. !log последние операции",
                                "3. !sum сложение",
                                "4. !sub вычитание",
                                "5. !mul умножение",
                                "6. !div деление",
                           };
                            foreach (var str in commands)
                                Console.WriteLine(str);

                            ////log.Add("!help");
                        }                       
                        break;

                    case "!log":
                        {
                            foreach (var str in log)
                                Console.WriteLine(str);
                            ////log.Add("!log");
                        }
                        break;

                    case "!sum":
                        {
                            Console.WriteLine("Введите первое число:");
                            if (Double.TryParse(Console.ReadLine(), out double x))
                            {
                                Console.WriteLine("Введите второе число:");

                                if (Double.TryParse(Console.ReadLine(), out double y))
                                {
                                    var result = calculate.Sum(x, y);
                                    Console.WriteLine("{0} + {1} = {2}", x, y, result);                          
                                    log.Add(x + " + " + y + " = " + result);
                                }
                                else
                                {
                                    Console.WriteLine("Введите число!");
                                    log.Add("Введите число!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Введите число!");
                                log.Add("Введите число!");
                            }
                        }
                        break;

                    case "!sub":
                        {
                            Console.WriteLine("Введите первое число:");
                            if (Double.TryParse(Console.ReadLine(), out double x))
                            {
                                Console.WriteLine("Введите второе число:");

                                if (Double.TryParse(Console.ReadLine(), out double y))
                                {
                                    var result = calculate.Sub(x, y);
                                    Console.WriteLine("{0} - {1} = {2}", x, y, result);
                                    log.Add(x + " - " + y + " = " + result);
                                }
                                else
                                {
                                    Console.WriteLine("Введите число!");
                                    log.Add("Введите число!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Введите число!");
                                log.Add("Введите число!");
                            }
                            break;
                        }

                    case "!mul":
                        {
                            Console.WriteLine("Введите первое число:");
                            if(Double.TryParse(Console.ReadLine(), out double x))
                            {
                                Console.WriteLine("Введите второе число:");

                                if (Double.TryParse(Console.ReadLine(), out double y))
                                {
                                    var result = calculate.Mul(x, y);
                                    Console.WriteLine("{0} * {1} = {2}", x, y, result);
                                    log.Add(x + " * " + y + " = " + result);
                                }
                                else
                                {
                                    Console.WriteLine("Введите число!");
                                    log.Add("Введите число!");
                                }
                            }  
                            else
                            {
                                Console.WriteLine("Введите число!");
                                log.Add("Введите число!");
                            }
                        }
                        break;

                    case "!div":
                        {
                            Console.WriteLine("Введите первое число:");
                            if (Double.TryParse(Console.ReadLine(), out double x))
                            {
                                Console.WriteLine("Введите второе число:");

                                if (Double.TryParse(Console.ReadLine(), out double y))
                                {
                                    if (y != 0)
                                    {
                                        var result = calculate.Div(x, y);
                                        Console.WriteLine("{0} / {1} = {2}", x, y, result);
                                        log.Add(x + " / " + y + " = " + result);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Знаменатель не должен быть равен 0!");
                                        log.Add("Знаменатель не должен быть равен 0!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Введите число!");
                                    log.Add("Введите число!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Введите число!");
                                log.Add("Введите число!");
                            }
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Введите команду корректно!");
                        }
                        break;

                }
            }
            


            //var c = args[0];
            //var a = Convert.ToInt32(args[1]);
            //var b = Convert.ToInt32(args[2]);
            //if (c == "sum")
            //{
            //    var result = a + b;
            //    Console.WriteLine(result);
            //}
            //Console.ReadKey();
        }
    }
}
