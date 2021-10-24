using System;

namespace Linkedlist_Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            int a = list.Search(30);
            Console.WriteLine("Index positon of element 30 is : " + a);
            list.InsertAtParticularPosition(a + 1, 40);
            list.Display();


        }
    }
}
