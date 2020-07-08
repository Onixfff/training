using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int number = 7; number < 100; number+= 7)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
            /*
            Выбрал цикл for потому что в нем удобно назначить начало цикла, конец цикла и шаг по которому этот цикл будет двигаться.
            Если брать while то number < 100 поставить не получится он будет смотреть если ли 98 < 100 то он запуститься, а for посмотрит что 98 < 100 и увидит какой
            шаг ему надо сделать и если этот шаг даст значение больше <100 он его не выполнит. 
            */
        }
    }
}
