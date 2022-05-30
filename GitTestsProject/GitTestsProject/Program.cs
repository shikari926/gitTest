using System;

namespace GitTestsProject
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Random random = new Random();
            var x = random.Next(100);
        }
        //MaksimMigur
        public double DigitsPow(double number, int pow) { return Math.Pow(number, pow); }
    }
}
