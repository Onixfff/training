﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Коля дунул в универе";
            string[] splitSentences = sentence.Split();

            foreach (var item in splitSentences)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
