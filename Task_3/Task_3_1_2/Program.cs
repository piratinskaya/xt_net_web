using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Please insert your text: ");
            string s = Console.ReadLine();            
            Dictionary<string, int> pairs = new Dictionary<string, int>();
            string str = s.ToLower();
            char[] chars = { ' ', ',', ':', '.', '!', '?' };
            string[] words = str.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item]++;
                }
                else
                {
                    pairs.Add(item, 1);
                }
            }

            int k = 0;
            string t = "";
            foreach (KeyValuePair<string, int> count in pairs)
            {
                Console.WriteLine("This word \"{0}\" occurs {1} times in your text",
                    count.Key, count.Value);
                if (count.Value > k)
                {
                    t = count.Key;
                    k = count.Value;
                }               
            }

            Console.WriteLine("This word \"{0}\" you use most often", t);
        }
    }
}
