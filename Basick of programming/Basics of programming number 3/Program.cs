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
            int row = 3;
            int картинки = 52;
            Console.WriteLine("Сколько рядов хотите вывести?");
            int howmanyrows = Convert.ToInt32(Console.ReadLine());
            int NumberofPicturesOnScreen = row *howmanyrows;
            int НеНадоКартинок = картинки - NumberofPicturesOnScreen;
            Console.WriteLine($"Выведется {NumberofPicturesOnScreen} картинок и {НеНадоКартинок} не появится на экране");
            Console.ReadKey();
        }
    }
}
