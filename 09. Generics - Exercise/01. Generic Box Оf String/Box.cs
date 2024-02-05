using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfString
{
    public class Box<T>
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
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }

    }
}
