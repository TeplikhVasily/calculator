using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class CalculateComand
    {
        private string comand;
        private double x;
        private double y;

        public string Comand
        {
            get
            {
                return comand;
            }
            set
            {
                if (value == "sum" || value == "sub" || value == "mul" || value == "div")
                {
                    comand = value;
                } 
                else
                {
                    Console.WriteLine("Введите корректную команду!");
                }

            }

        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }

        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Знаменатель не должен быть равен 0!");
                }
                else
                {
                    y = value;
                }
            }

        }


    }
}
