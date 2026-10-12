using System.Reflection.Metadata.Ecma335;

namespace Task_1_1
{
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"> Список формальных параметров. </param>
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 3;
            const double c = 1;

            double x = GetNumber("Введите x = ");

            double y = GetResult(a, b, c, x);

            Console.WriteLine($"x = {x}; y = {y}");
        }
        /// <summary>
        /// Получает число.
        /// </summary>
        /// <param name="message"> Сообщение пользователю. </param>
        /// <returns> Число, введенное с клавиатурыю </returns>
        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return double.Parse(input);
        }

        /// <summary>
        /// Поулчает расчет функции.
        /// </summary>
        /// <param name="a"> Константа a. </param>
        /// <param name="b"> Константа b. </param>
        /// <param name="c"> Константа c. </param>
        /// <param name="x"> Переменная x. </param>
        /// <returns> Значение функции. </returns>
        static double GetResult(double a, double b, double c, double x)
        {
            return (5.0 / 6.0) * a * Math.Sqrt(x * x + b * b) / (Math.Abs(x) + c) + Math.Cos(x) * Math.Cos(x);
        }
    }
}
