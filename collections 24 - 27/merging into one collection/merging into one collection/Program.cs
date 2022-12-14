using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merging_into_one_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] charsArrayTwo = new string[] { "2", "5", "6", "3" };
            string[] charsArrayOne = new string[] { "1", "2", "3", "4" };
            List<string> combinedCollection = new List<string>(charsArrayOne);

            foreach (var item in combinedCollection)
            {
                Console.Write(item);
            }

            foreach (var item in charsArrayTwo)
            {
                bool check = combinedCollection.Contains(item);
                if (check == false)
                    combinedCollection.Add(item);
            }

            Console.WriteLine();

            foreach (var item in combinedCollection)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
