using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph_SearchPath
{
    public class ArrayList<T> : ICloneable
    {
        const int EXP_MULT = 2;
        const int START_LENGTH = 4;

        T[] mas;
        int capacity;
        public int length;

        public ArrayList()
        {
            capacity = START_LENGTH;
            length = 0;
            mas = new T[capacity];
        }


        public ArrayList(int n)
        {
            capacity = n;
            length = 0;
            mas = new T[capacity];
        }

        public ArrayList(T[] mas)
        {
            capacity = mas.Length;
            length = capacity;
            this.mas = new T[mas.Length];
            System.Array.Copy(mas, this.mas, capacity);
        }

        public ArrayList(ArrayList<T> initList)
        {
            if (initList != null)
            {
                capacity = initList.capacity;
                length = initList.length;
                mas = new T[capacity];
                System.Array.Copy(initList.mas, mas, capacity);
            }
            else
            {
                capacity = START_LENGTH;
                length = 0;
                mas = new T[capacity];
            }
        }

        public T get  (int index)  
        {
           // if (length <= index) throw new IndexOutOfRangeException();
            return mas[index];
        }

        public void add(T o)
        {
            if (length == capacity)
            {
                T[] new_mas = new T[capacity * EXP_MULT];
                System.Array.Copy(mas, new_mas, capacity);
                capacity *= EXP_MULT;
                mas = new_mas;
            }
            mas[length] = o;
            length++;
        }


        public void addAll(T[] mas)
        {
            int len = mas.Length;
            for (int i = 0; i < len; i++)
            {
                add(mas[i]);
            }


        }

        public void addAll(int index, T[] mas)
        {
            int len = mas.Length;
            for (int i = len-1; i >= 0; i--)
            {
                add(index, mas[i]);
            }
        }


        public void add(int pos, T o)
        {
            T[] new_mass = new T[capacity + 1];
            System.Array.Copy(mas, new_mass, pos);
            new_mass[pos] = o;
            System.Array.Copy(mas, pos, new_mass, pos + 1, capacity - pos);
            mas = new_mass;

            capacity++;
            length++;
        }

        public int size()
        {
            return length;
        }

        override public String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < length; i++)
            {
                sb.Append(mas[i].ToString());
                sb.Append((i != length-1) ? ", " : "");
            }

            sb.Append("]");

            return sb.ToString();
        }

        public T[] ToArray()
        {
            T[] out_mas = new T[length];
            System.Array.Copy(mas, out_mas, length);
            return out_mas;
        }

        public ArrayList<T> subList(int start, int end)
        {
            if (start>end) return new ArrayList<T>();
            T[] new_mas = new T[end - start];
            System.Array.Copy(mas, start, new_mas, 0, end - start);
            return new ArrayList<T>(new_mas);
        }


        public object Clone()
        {
            return new ArrayList<T>(this);
        }

        override public bool Equals(object o)
        {
            if(length != ((ArrayList<T>) o).length) return false;
            for(int i=0; i<length; i++)
                if (!((ArrayList<T>)o).get(i).Equals(mas[i])) return false;

            return true;
        }
    }
}