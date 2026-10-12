namespace Task_1_2
{
    internal static class Program
    {
        /// <summary >
        /// Точка входа в программу.
        /// </summary >
        /// <param name="args"> Список формальных параметров. </param >
        static void Main(string[] args)
        {
            double a = GetNumber("Введите a = ");
            double b = GetNumber("Введите b = ");
            double c = GetNumber("Введите углол между сторонами c = ");

            double x = GetResult(a, b, c);


            Console.WriteLine($"a = {a}; b = {b}; угол = {c}; третья сторона = {x}");
            c *= Math.PI / 180;
            double z = 0.5 * a * b * Math.Sin(c);
            Console.WriteLine($"площадь = {z}");
        }

        /// <summary >
        /// Получает число.
        /// </summary >
        /// <param name="message"> Сообщение пользователю.</param >
        /// <returns > Число, введенное с клавиатуры. </returns >
        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();


            return double.Parse(input);

        }

        /// <summary >
        /// Получает расчёт функции.
        /// </summary >
        /// <param name="a"> Переменная a. </param >
        /// <param name="b"> Переменная b. </param >
        /// <param name="c"> Переменная c. </param >
        /// <returns > Значение функции. </returns >
        static double GetResult(double a, double b, double c)
        {
            c *= Math.PI / 180;
            double x = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(c));
            return x;
            
        }
    }
}
