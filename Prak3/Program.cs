using System;
using System.Collections.Generic;

namespace Prak3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter items count: ");
            int count = int.Parse(Console.ReadLine());
            List<int> list = GenerateList(count);

            Console.WriteLine("Enter item for search: ");
            int item = int.Parse(Console.ReadLine());

            Console.WriteLine(FindValueByIndexOf(list, item));
            Console.WriteLine(FindValueByFor(list, item));
        }

        public static List<int> GenerateList(int n)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next(0, i + 1));
            }

            return list;
        }

        public static int FindValueByIndexOf(List<int> list, int n)
        {
            return list.IndexOf(n);
        }

        public static int FindValueByFor(List<int> list, int n)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n)
                    return i;
            }
            return -1;
        }
    }
}
