using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            DoublyLinkedList<string> listString = new DoublyLinkedList<string>();

            listString.AddFirst("some");
            listString.AddFirst("random");
            listString.AddFirst("string");

            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }
        }
    }
}

