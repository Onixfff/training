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
            int howManyRows;
            int NumberOfPicturesOnScreen;
            int NoPicturesNeeded;
            
            Console.WriteLine("Сколько рядов хотите вывести?");
            howManyRows = Convert.ToInt32(Console.ReadLine());
            enoughPictutes = pictures >= row * howmanyrows;
            howManyRows *= Convert.ToInt32(enoughPictutes);
            NumberOfPicturesOnScreen = row * howManyRows;
            NoPicturesNeeded = pictures - NumberOfPicturesOnScreen;
            Console.WriteLine($"Выведется {NumberOfPicturesOnScreen} картинок и {NoPicturesNeeded} не появится на экране");
            Console.ReadKey();
        }
    }
}
