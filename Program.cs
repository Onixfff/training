using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Переменные
{
    class Task_number_1
    {
        static void Main(string[] args)
        {
            //Основные типы : int, uint | float | char | string | bool |
            //Целочисленные
            byte b; // 0 до 255
            sbyte sb; // -128 до 127
            short sh; // -32768 до 32767
            ushort us; // 0 до 65535
            int i; // -2147483648 до 214743647
            uint ui; // 0 до 4294967295
            long ln = long.MaxValue; // очень огромные числа
            ulong ul = ulong.MaxValue; //
            // Числа с плавающей точкой
            float fl = 5.7f; // 7 знаков
            double db = 5.7; // 15 знаков
            // Символьный тип
            char ch = '!'; 
            // Строковые
            string str = "Привет, мир!";
            // Логические
            bool bl = false; // true или false;
        }
    }
}
