using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace _300904358_Nahapetyan__ASS6Q2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSinglyLinkedList list = new SortedSinglyLinkedList("My List");

            list.Display();

            list.Insert(1);

            list.Display();

            list.Insert(5);

            list.Display();

            list.Insert(2);

            list.Display();

            list.Insert(5);
            //list.Insert(2);

            list.Display();

            list.Insert(0);
            list.Insert(-1);

            list.Display();

            object removedObject = -1;

            try
            {
                list.Remove(Convert.ToInt32(removedObject));
                Console.WriteLine(removedObject + " removed");
                list.Display();

                removedObject = 5;
                list.Remove(Convert.ToInt32(removedObject));
                Console.WriteLine(removedObject + " removed");
                list.Display();

                removedObject = 5;
                list.Remove(Convert.ToInt32(removedObject));
                Console.WriteLine(removedObject + " removed");
                list.Display();

                removedObject = 0;
                list.Remove(Convert.ToInt32(removedObject));
                Console.WriteLine(removedObject + " removed");
                list.Display();

                removedObject = 2;
                list.Remove(Convert.ToInt32(removedObject));
                Console.WriteLine(removedObject + " removed");
                list.Display();
            } 
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine("\n" + emptyListException);
            }

            list.Insert(4);
            list.Insert(-1);

            list.Display();

            //list.Display();

            Console.ReadLine();

        }
    }
}
