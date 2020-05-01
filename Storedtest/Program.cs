using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Storedtest
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDictionay();
        }
        public static void WordDictionay()
        {

           string sen=  Console.ReadLine();

            var dictionary = new SortedDictionary<string, int>();

            string[] words = Regex.Split(sen, @"\s+");

            foreach (var item in words)
            {

                if (dictionary.ContainsKey(item))
                    ++dictionary[item];
                else
                {
                    dictionary.Add(item, 1);
                }

            }

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key,-12}{dictionary[key],-12}");
            }
          
                  


           var max = dictionary.Values.Max();
            var maxkey = dictionary.Where(p => max.Equals(p.Value)).Select(p => p.Key).First();


            Console.WriteLine($"{max,-12}{maxkey,-12}");
        }
    }
}
