namespace Task_1_3
{
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            double length = GetNumber("Введите длину в метрах = ");
            double crossSectionalArea = GetNumber("Введите площадь поперечного сечения в мм2 = ");
            double resistivity = GetNumber("Введите сопротивление материала в Ом*мм2/м = ");

            double wireResistance = GetResult(length, crossSectionalArea, resistivity);

            Console.WriteLine($"длина = {length}; площадь сечения = {crossSectionalArea}; удельное сопротивление = {resistivity}; сопротивление провода = {wireResistance}");
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
        /// <param name="length"> Переменная length. </param>
        /// <param name="crossSectionalArea"> Переменная s. </param>
        /// <param name="resistivity"> Переменная po. </param>
        /// <param name="wireResistance"> Переменная R. </param>
        /// <returns> Значение функции. </returns>
        static double GetResult(double length, double crossSectionalArea, double resistivity)
        {
            return (resistivity * length / crossSectionalArea);
        }
    }
}
