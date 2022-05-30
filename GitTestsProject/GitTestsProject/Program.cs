using System;

namespace GitTestsProject
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random random = new Random();
            var x = random.Next(100);
            int a = 4;
            int b = 3;
            var text = Console.ReadLine();
            Console.WriteLine(Max(a, b));
        }

        //Максим добавить метод возведения числа в степень б\\

        //Миша - метод умножения всех числел от а до б

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

    }
}
