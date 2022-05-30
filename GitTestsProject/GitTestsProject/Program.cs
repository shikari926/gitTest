using System;

namespace GitTestsProject
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Random random = new Random();
            var x = random.Next(100);

            Console.WriteLine("Hello World!");
            int a = 3;
            int b = 4;
            Console.WriteLine(multiply(a, b));
            var text = Console.ReadLine();
            Console.WriteLine(Max(a, b));
        }


        //Максим добавить метод возведения числа в степень б

        //Миша - метод умножения всех числел от а до б
        public static int multiply(int a, int b) {
            int c = 1;
            while (a <= b) {
                c = c * a;
                a++;
            }
            return c;
        }

        // Костя - добавить метод какое из числе меньше а или б

        // Тая - добавить метод поиска большего сдели а и б
        private static int Max(int a, int b)
        {
            if (a > b)
                return a;
            else if (a < b)
                return b;
            else
                return 0;
        }
        // Артем -  добавить метод вывода а и б на консоль

        //MaksimMigur
        public double DigitsPow(double number, int pow) { return Math.Pow(number, pow); }
    }
}
