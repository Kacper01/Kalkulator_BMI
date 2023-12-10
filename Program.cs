using System;
using Kalkulator_BMI;

namespace Kalkulator_BMI
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Podaj swój wzrost w centymetrach:");
            var height = UserInput.AddParameter();
            Console.WriteLine("Podaj swoją wagę w kilogramach:");
            var weight = UserInput.AddParameter();

            var result = weight / Math.Pow(height / 100f, 2);
            result = Math.Round(result, 2);
            Console.WriteLine($"Twój wzrost wynosi: {height}cm");
            Console.WriteLine($"Twoja waga wynosi: {weight}kg");
            Console.WriteLine($"Twoje BMI wynosi: {result}");
        }
    }

}




