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
            List<string> combinedCollection = null;
            string[] charsArrayOne = new string[] { "1", "2", "3", "4" };
            string[] charsArrayTwo = new string[] { "2", "5", "6", "3" };

            AddsArrayinCollection(ref combinedCollection, charsArrayOne);
            AddsArrayinCollection(ref combinedCollection, charsArrayTwo);

            Console.WriteLine();

            ShowList(combinedCollection);

            Console.ReadKey();
        }

        static void AddsArrayinCollection(ref List<string> combinedCollection, string[] array)
        {
            if(combinedCollection != null)
            {
                foreach (var item in array)
                {
                    bool isContains = combinedCollection.Contains(item);
                    if (isContains == false)
                        combinedCollection.Add(item);
                }
            }
            else
            {
                combinedCollection = new List<string>(array);
            }
        }

        static void ShowList(List<string> array)
        {
            foreach (var item in array)
            {
                Console.Write(item);
            }
        }
    }
}
