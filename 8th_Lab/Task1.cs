using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_Lab
{
    internal class Task1
    {
        static string text;
        static int total;
        static Dictionary<Char, int> dict;
        public static void Run()
        {
            Console.WriteLine("введите текст");
            text = Console.ReadLine().ToLower();
            SetStatistic();
            PrintStatistic();
            Console.WriteLine();
        }

        static void SetStatistic()
        {
            dict = new Dictionary<Char, int>();
            total = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                    total++;

                if (text[i] >= 0x0430 && text[i] <= 0x044F)
                {
                    if (!dict.ContainsKey(text[i]))
                        dict[text[i]] = 1;
                    else
                        dict[text[i]]++;
                }
            }
        }

        static void PrintStatistic()
        {
            foreach(var pair in dict)
            {
                double frequency = (double)pair.Value / total;
                Console.WriteLine("symbol: {0} {1:0.#}%", pair.Key, pair.Value);
            }
        }
    }
}
