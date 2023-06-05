using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpBasics
{
    class Homework_1
    {
        static void Main(string[] args)
        {
            new Homework_1().Task_1();
            new Homework_1().Task_2();
            new Homework_1().Task_3();
            new Homework_1().Task_4();
            new Homework_1().Task_5();
            new Homework_1().Task_6();
            new Homework_1().Task_7();
        }

        public void Task_1()
        {



            //Первый вариант

            int a = 5;
            double b = 5.56;
            char c = 'c';
            bool d = false;
            string e = "Hello";
            Console.WriteLine($"5 Переменных различныйх типов: \n" + $"Целочисленный: {a} \n" + $"Значения с точкой: {b} \n" + $"Символьный: {c}  \n" + $"Логический: {d}  \n" + $"Ссылочный: {e}  \n");

            //Второй вариант Вывода

            Console.WriteLine("5 Переменных различныйх типов:");
            Console.WriteLine("int: " + a);
            Console.WriteLine("double: " + b);
            Console.WriteLine("char: " + c);
            Console.WriteLine("bool: " + d);
            Console.WriteLine("string: " + e);

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();
        }

      
     

    }      
    }
}
