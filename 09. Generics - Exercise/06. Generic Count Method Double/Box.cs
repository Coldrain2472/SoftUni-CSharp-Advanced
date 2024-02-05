using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> Items { get; set; }

        public Box()
        {
            Items = new List<T>();
        }

        public void Add(T item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T newItem = Items[firstIndex];

            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = newItem;
        }

        public int Compare(T itemToCompare)
        {
            int count = 0;

            foreach (var item in Items)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
