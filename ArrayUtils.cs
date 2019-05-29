using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph_SearchPath
{
    class ArrayUtil
    {
        public static void fill<T>(T[] mas, T el)
        {
            int len = mas.Length;
            for (int i = 0; i < len; i++)
            {
                mas[i] = el;
            }
        }

        public static void fill<T>(T[][] mas, T el)
        {
            int len = mas.Length;
            for (int i = 0; i < len; i++)
            {
                fill(mas[i], el);
            }
        }

        public static void addAll<T>(ICollection<T> col, T[] mas)
        {
            int len = mas.Length;
            for (int i = 0; i < len; i++)
            {
                col.Add(mas[i]);
            }
        }
    }
}
