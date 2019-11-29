using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace _300904358_Nahapetyan__ASS6Q2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List list1 = new List("My List_1");
            List list2 = new List("My List_2");

            list1.InsertAtBack(-1);
            list1.InsertAtBack(1);
            list1.InsertAtBack(4);
            list1.InsertAtBack(5);
            list1.InsertAtBack(6);

            list1.Display();

            list2.InsertAtBack(0);
            list2.InsertAtBack(2);
            list2.InsertAtBack(3);
            list2.InsertAtBack(5);

            list2.Display();

            List listMerge = Merge(list1, list2);

            Console.WriteLine("Merged List:");
            listMerge.Display();

            Console.ReadLine();
        }

        public static List Merge(List list1, List list2)
        {
            ListNode listNode1 = list1.GetFirst();
            ListNode listNode2 = list2.GetFirst();

            List mergedList = new List();

            while (listNode1 != null || listNode2 != null) //both of them are null, second one is null, first one is null
            {
                if (listNode1 == null)
                {
                    mergedList.InsertAtBack(listNode2.Data);
                    listNode2 = listNode2.Next;
                }
                else if (listNode2 == null)
                {
                    mergedList.InsertAtBack(listNode1.Data);
                    listNode1 = listNode1.Next;
                }
                else if ((int)listNode1.Data <= (int)listNode2.Data)
                {
                    mergedList.InsertAtBack(listNode1.Data);
                    listNode1 = listNode1.Next;
                }
                else // >
                {
                    mergedList.InsertAtBack(listNode2.Data);
                    listNode2 = listNode2.Next;
                }
            }

            return mergedList;
        }

    }
}
