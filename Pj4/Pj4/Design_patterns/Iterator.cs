using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4
{
    public interface Iterator<T>
    {
        Option<T> GetNext();
       // Option<T> GetCurrent();
        void Reset();
    }
    public class IterableArray<T> : Iterator<T>
    {
        private int size;
        private T[] array;
        private int current;
        private int amount_of_items;

        public IterableArray()
        {
            size = 10;
            amount_of_items = 0;
            current = 0;
            array = new T[10];
            Reset();
        }
        public void Add(T item)
        {
            if (amount_of_items >= size)
            {
                size *= 2;
                T[] new_array = new T[size];
                Array.Copy(array, new_array, amount_of_items);
            }
            else
            {
                array[amount_of_items] = item;
            }
            amount_of_items++;

        }

        public Option<T> GetNext()
        {
            current++;
            if (current >= amount_of_items)
            {
                return new None<T>();
            }
            return new Some<T>(array[current]);
        }

        public void Reset()
        {
            current = -1;
        }

        public Option<T> GetCurrent()
        {
            if (current == -1) return new None<T>();
            return new Some<T>(array[current]);
        }
    }
    public class IterableOption<T> : Iterator<T>
        {
            Option<T> item;
            bool visited = false;
            public IterableOption(Option<T> item)
            {
                this.item = item;
            }
            public Option<T> GetNext()
            {
                if (visited) return new None<T>();
                visited = true;
                return this.item;
            }

            public void Reset()
            {
                visited = false;
            }
        }
        
}
