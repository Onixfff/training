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
            int userInput;
            userInput = ReadData();
            Console.WriteLine("Вы вывели число" + userInput);
            Console.ReadKey();
        }

        static int ReadData()
        {
            int resultConvert;
            do
            {
                Console.Write("Введите целое число: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out resultConvert);
                if (resultConvert == 0)
                {
                    Console.WriteLine("Вы ошиблись повторите попытку!\n");
                }
                return resultConvert;
            }
            while (resultConvert == 0);
        }
    }
}
