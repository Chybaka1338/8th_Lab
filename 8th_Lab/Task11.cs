using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8th_Lab
{
    internal class Task11
    {
        static string lastNames = "Юрасова, Евтеров, Теряев, Феофилов, Рыжова, Ершов, Зотов, Мухов, Васильев";
        static string[] array;
        public static void Run()
        {
            array = lastNames.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //Array.ForEach(array, item => { Console.WriteLine(item); });

            Sort();
            Array.ForEach(array, item => { Console.WriteLine(item); });
        }

        static void Sort()
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                string lastName = array[i];
                int curIndex = i;
                for(int j = i + 1; j< array.Length; j++)
                {
                    if(Compare(lastName, array[j]))
                    {
                        lastName = array[j];
                        curIndex = j;
                    }
                }
                array[curIndex] = array[i];
                array[i] = lastName;
            }
        }

        static bool Compare(string s1, string s2)
        {
            int length = s1.Length > s2.Length ? s1.Length : s2.Length;
            for(int i = 0; i < length; i++)
            {
                if (s1.ToCharArray()[i] == s2.ToCharArray()[i])
                    continue;
                return s1.ToCharArray()[i] > s2.ToCharArray()[i];
            }
            return false;
        }
    }
}
