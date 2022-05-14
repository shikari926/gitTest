using System;

namespace GitTestsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 3;
            int b = 4;
        }

        public void add(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a+">"+b);
            }
            else
            {
                Console.WriteLine(a+"<"+b);
            }
        }
        //Максим добавить метод возведения числа в степень б


        //Миша - метод умножения всех числел от а до б

        // Костя - добавить метод какое из числе меньше а или б

        // Тая - добавить метод поиска большего сдели а и б

        // Артем -  добавить метод вывода а и б на консоль
    }
}
