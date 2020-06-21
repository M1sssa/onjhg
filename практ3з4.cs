using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практ3з08
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_n = int.Parse(Console.ReadLine());
            double number_a = 1;
            double number_m = double.Parse(Console.ReadLine());

            for (int number_l = 1; number_l <= number_n; number_l++)
            {
                number_a = (number_l * (number_l - number_a) * (number_l - number_m + number_a));
            }
            Console.WriteLine(number_a);
            Console.ReadKey();
        }
    }
}
