using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_programming_number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 38 * 17;
            //int c = (31 - 5 * a) / b;
            float c = (31f - 5f * a) / b;
            Console.WriteLine(c);
            Console.ReadKey();

            //ВАЖНО!!! Не запускать код и попытаться подумать головой
            //не очень понял суть задания то что ответ будет целое число или то что  Console.ReadKey(); нету и я никак без него не посмотрю число
        }
    }
}
