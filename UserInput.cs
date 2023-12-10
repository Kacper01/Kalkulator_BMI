using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_BMI
{
    class UserInput
    {
        public static int AddParameter()
        {
            while(true)
            {
                int parameter;
                if (int.TryParse(Console.ReadLine(), out parameter))
                {
                    return parameter;
                }
                else
                {
                    Console.WriteLine("Parametr musi być liczbą całkowitą! Spróbuj ponownie:");
                }
            }

          
        }
    }
}
