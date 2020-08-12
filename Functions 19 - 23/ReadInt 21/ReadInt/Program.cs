using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultConvert;
            ReadUserInput(out resultConvert);
            Console.WriteLine("Вы вывели число: " + resultConvert);
            Console.ReadKey();
        }

        static void ReadUserInput(out int resultConvert)
        {
            bool transformation;
            do
            {
                Console.Write("Введите целое число: ");
                string userInput = Console.ReadLine();
                transformation = int.TryParse(userInput, out resultConvert);

                if (transformation == false)
                {
                    Console.WriteLine("Вы ошиблись повторите попытку!\n");
                }
            }
            while (transformation == false);
        }
    }
}
