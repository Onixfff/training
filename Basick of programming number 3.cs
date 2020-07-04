using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_programming_number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ряд = 3;
            int картинки = 52;
            Console.WriteLine("Сколько рядов хотите вывести?");
            int скролькоРяд = Convert.ToInt32(Console.ReadLine());
            int t = ряд * скролькоРяд;
            int НеНадоКартинок = картинки - t;
            Console.WriteLine($"Выведется {t} картинок и {НеНадоКартинок} не появится на экране");
            Console.ReadKey();
        }
    }
}
