using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_Excersizes
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInTwoRows("gil", "avia");
            PrintInTwoRows(33, 43);
            PrintInTwoRows(2 > 3, 4 == 4);
        }

        public static void PrintInTwoRows(string str1, string str2)
        {
            Console.WriteLine(str1 + "\n" + str2);
        }

        public static void PrintInTwoRows(int num1, int num2)
        {
            Console.WriteLine($"{num1}\n{num2}");
        }

        public static void PrintInTwoRows(bool booli1, bool booli2)
        {
            Console.WriteLine($"{booli1}\n{booli2}");
        }
    }

    public class Calculator
    {
        public int CalcInt(int n1, int n2, string op)
        {
            switch (op)
            {
                case "+":
                    return n1 + n2;
                    break;
                case "-":
                    return n1 - n2;
                    break;
                case "*":
                    return n1 * n2;
                    break;
                case "/":
                    return n1 / n2;
                    break;
                default:
                    return 0;
                    break;
            }
        }


        public double CalcDouble(double n1, double n2, string op)
        {
            switch (op)
            {
                case "+":
                    return n1 + n2;
                    break;
                case "-":
                    return n1 - n2;
                    break;
                case "*":
                    return n1 * n2;
                    break;
                case "/":
                    return n1 / n2;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        public string CalcString(int n1, int n2, string op)
        {
            switch (op)
            {
                case "+":
                    return $"{n1 + n2}";
                    break;
                case "-":
                    return $"{ n1 - n2}";
                    break;
                case "*":
                    return $"{ n1 * n2}";
                    break;
                case "/":
                    return $"{ n1 / n2}";
                    break;
                default:
                    return "0";
                    break;
            }
        }
    }
}
