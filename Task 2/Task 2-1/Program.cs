using System;

namespace Task_2_1
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            double a = GetNumber("Введите первое число a = ");
            double b = GetNumber("Введите второе число b = ");

            double arithmeticMean;
            double geometricMean;
            string resultMessage;

            if (a > 0 && b > 0)
            {
                arithmeticMean = GetArithmeticMean(a, b);
                geometricMean = GetGeometricMean(a, b);
                resultMessage = "Числа положительны. Считаем для самих чисел.";
            }
            else
            {
                double cubeA = a * a * a;
                double cubeB = b * b * b;

                double absA = Math.Abs(a);
                double absB = Math.Abs(b);

                arithmeticMean = GetArithmeticMean(cubeA, cubeB);
                geometricMean = GetGeometricMean(absA, absB);
                resultMessage = "Числа не положительны. Считаем для кубов и модулей.";
            }

            Console.WriteLine($"{resultMessage}");
            Console.WriteLine($"Среднее арифметическое: {arithmeticMean}");
            Console.WriteLine($"Среднее геометрическое: {geometricMean}");
        }

        /// <summary>
        /// Получает число.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Число, введенное с клавиатуры.</returns>
        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            return double.Parse(input);
        }

        /// <summary>
        /// Вычисляет среднее арифметическое двух чисел.
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        /// <returns>Среднее арифметическое.</returns>
        static double GetArithmeticMean(double x, double y)
        {
            return (x + y) / 2.0;
        }

        /// <summary>
        /// Вычисляет среднее геометрическое двух чисел.
        /// </summary>
        /// <param name="x">Первое число.</param>
        /// <param name="y">Второе число.</param>
        /// <returns>Среднее геометрическое (корень из произведения).</returns>
        static double GetGeometricMean(double x, double y)
        {
            return Math.Sqrt(x * y);
        }
    }
}