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
            int pictures = 52;
            bool enoughPictutes;
            Console.WriteLine("Сколько рядов хотите вывести?");
            int howmanyrows = Convert.ToInt32(Console.ReadLine());
            enoughPictutes = pictures >= row * howmanyrows;
            howmanyrows *= Convert.ToInt32(enoughPictutes);
            int NumberofPicturesOnScreen = row *howmanyrows;
            int NopicturesNeeded = pictures - NumberofPicturesOnScreen;
            Console.WriteLine($"Выведется {NumberofPicturesOnScreen} картинок и {NopicturesNeeded} не появится на экране");
            Console.ReadKey();
        }
    }
}
