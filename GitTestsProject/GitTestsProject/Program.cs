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

        // Артем -  добавить метод вывода а и б на консоль
    }
}
