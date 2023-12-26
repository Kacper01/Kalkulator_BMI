using System;
using Kalkulator_BMI;

namespace Kalkulator_BMI
{
    class Program
    {
        public static void Main()
        {
            height:
            Console.WriteLine("Podaj swój wzrost w centymetrach:");
            var height = UserInput.AddParameter();
            if (height <= 220 && height >= 100)
            {
                
            }
            else
            {
                goto height;
            }

            weight:
            Console.WriteLine("Podaj swoją wagę w kilogramach:");
            var weight = UserInput.AddParameter();
            if (weight <= 250 && weight >= 20)
            {

            }
            else
            {
                goto weight;
            }

            var result = weight / Math.Pow(height / 100f, 2);
            result = Math.Round(result, 2);
            Console.WriteLine($"Twój wzrost wynosi: {height}cm");
            Console.WriteLine($"Twoja waga wynosi: {weight}kg");
            Console.WriteLine($"Twoje BMI wynosi: {result}");
        }
    }

}




