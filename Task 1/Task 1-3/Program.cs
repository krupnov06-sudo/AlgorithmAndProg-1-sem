namespace Task_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = GetNumber("Введите длину в метрах = ");
            double s = GetNumber("Введите площадь поперечного сечения в мм2 = ");
            double po = GetNumber("Введите сопротивление материала в Ом*мм2/м = ");

            double R = GetResult(length, s, po);

            Console.WriteLine($"длина = {length}; площадь сечения = {s}; удельное сопротивление = {po}; сопротивление провода = {R}");
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
        static double GetResult(double length, double s, double po)
        {
            return (po * length / s);
        }
    }
}
