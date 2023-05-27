using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Console.MyObjects
{
    public class RealList<T>
    {
        public T[] items;

        public int count;

        public RealList()
        {
            items = new T[4];
            count = 0;
        }


        public void Add(T item)
        {
            if (count == items.Length)
            {
                ResizeArray();
            }

            items[count] = item;
            count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            return items[index];
        }
        private void ResizeArray()
        {
            T[] newArray = new T[items.Length * 2];
            Array.Copy(items, newArray, items.Length);
            items = newArray;
        }

        public int Count { get { return count; } }
    }
}
