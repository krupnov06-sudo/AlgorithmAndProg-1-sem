namespace Task_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 3;
            const double c = 1;

            Console.Write("Введите x = ");
            string input = Console.ReadLine();
            double x = double.Parse(input);

            double y = (5.0 / 6.0) * a * Math.Sqrt(x * x + b * b) / (Math.Abs(x) + c) + Math.Cos(x) * Math.Cos(x);
            Console.WriteLine($"x = {x}; y = {y}");
        }
    }
}
