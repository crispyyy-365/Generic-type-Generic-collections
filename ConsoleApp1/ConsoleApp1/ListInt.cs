using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CustomList<T>
    {
        private T[]? arr;
        public CustomList() { }
        public CustomList(int index)
        {
            arr = new T[index];
        }
        public CustomList(T[]? arr)
        {
            this.arr = arr;
        }
        public void IndexRange(params T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[i] = array[i];
            }
        }
        public bool Contains(T item)
        {
            return arr.Contains(item);
        }
        public int Sum()
        {
            if (arr is int)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += Convert.ToInt32(arr[i]);
                }
                return sum;
            }
            else
            {
                return 0;
            }
        }
        public T[] Remove(T value)
        {
            int count = 0;

            foreach (T item in arr)
            {
                if (item != value)
                {
                    count++;
                }
            }

            T[] result = new T[count];
            int index = 0;

            foreach (T item in arr)
            {
                if (item != value)
                {
                    result[index++] = item;
                }
            }

            return result;
        }
        public void ToString()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].ToString} ,");
            }
        }
    }
}
