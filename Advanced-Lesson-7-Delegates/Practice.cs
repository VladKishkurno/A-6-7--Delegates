using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_7_Delegates
{
    public class Practice
    {
        delegate double Operator(int Val1, int Val2);
        /// <summary>
        /// L7.P1. Переписать консольный калькулятор с использованием делегатов. 
        /// Используйте switch/case, чтоб определить какую математическую функцию.
        /// </summary>
        public static void L7P1_Calculator()
        {
            int ch1 = 5;
            int ch2 = 10;

            Operator @operator = null;

            switch (Console.ReadLine())
            {
                case "+":
                    {
                        @operator = delegate (int var1, int var2)
                        {
                            return var1 + var2;
                        };

                        break;
                    }
                case "-":
                    {
                        @operator = (a, b) => a - b; //лямбда выражение
                        break;
                    }
                case "*":
                    {
                        @operator = Deg;
                        break;
                    }
                case "/":
                    {
                        @operator = Del;
                        break;
                    }
            }

            Console.WriteLine(@operator(ch1, ch2));
        }

        public static double Minus(int val1, int val2)
        {
            return val1 - val2;
        }

        public static double Deg(int val1, int val2)
        {
            return val1 * val2;
        }

        public static double Del(int val1, int val2)
        {
            return val1 / val2;
        }
        /// <summary>
        /// L7.P2. Создать расширяющий метод для коллекции строк.
        /// Метод должен принимать делегат форматирующей функции для строки.
        /// Метод должен проходить по всем элементам коллекции и применять данную форматирующую функцию к каждому элементу.
        /// Реализовать следующие форматирующие функции:
        /// Перевод строки в заглавные буквы.
        /// Замена пробелов на подчеркивание.
        /// Продемонстрировать работу расширяющего метода.
        /// </summary>
        public static void L7P2_StringFormater()
        {
            string[] str = { "sde1312rfw _ eeeacs  acvacv", "eeee  eee  eeeeeeee ee", "1edf  gf  fwq3" };
            
            var result = str.Format(UpperString).Format(ChangeChar);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static string UpperString(string str)
        {
            return str.ToUpper();
        }

        public static string ChangeChar(string str)
        {
            return str.Replace(' ', '_');
        }

    }
}
