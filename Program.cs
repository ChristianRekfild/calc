using System;
using System.Data;

namespace String_Calc {
    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Добро пожаловать в программу калькулятор v1.1");
            Console.WriteLine("Введите выражение для вычисления");

            string math = Console.ReadLine();


            //пусть оно вычисляет само себя. Не зря же я несколько часов искал и курил информацию, как сделать это всё проще.
            string value = new DataTable().Compute(math, null).ToString();



            bool flag = true;
            foreach (char c in value) {
                if (!char.IsDigit(c) && c != '.') {
                    flag = false;
                }
            }

            if (flag) {
                Console.WriteLine(value);
            } else {
                Console.WriteLine("Ошибка вычисления - введены некорректные данные или присутствует деление на ноль");
            }


        }
    }
}
