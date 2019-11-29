using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace _300904358_Nahapetyan__ASS6Q2_1
{
    public class SortedSinglyLinkedList
    {
        private ListNode rootNode;
        private string name;

        public SortedSinglyLinkedList(string listName)
        {
            name = listName;
            rootNode = null;
        }

        public void Insert(int data)
        {
            if (IsEmpty())
            {
                rootNode = new ListNode(data);
            }
            else
            {
                ListNode newNode = new ListNode(data);
                
                ListNode beforeNode = rootNode;
                ListNode afterNode = beforeNode.Next;

                if ((int)rootNode.Data > data)
                {
                    newNode.Next = rootNode;
                    rootNode = newNode;
                }
                else
                {
                    while (true)
                    {
                        if (afterNode == null)
                        {
                            beforeNode.Next = newNode;
                            break;
                        }
                        else if ((int)afterNode.Data >= data)
                        {
                            //Insert
                            beforeNode.Next = newNode;
                            newNode.Next = afterNode;
                            break;
                        }
                        else
                        {
                            beforeNode = afterNode;
                            afterNode = afterNode.Next;
                        }
                    }
                }



            }
                
        }

        public void Remove(int data)
        {
            //get somthing to point to the one after, handel root node in a speical, to remove 1 get the root node to be 2
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }
            else
            {
                ListNode beforeNode = rootNode;
                ListNode afterNode = beforeNode.Next;

                if ((int)rootNode.Data == data)
                {
                    rootNode = afterNode;
                }
                else
                {
                    while (true)
                    {
                        if ((int)afterNode.Data == data)
                        {
                            if (afterNode.Next == null)
                            {
                                beforeNode.Next = afterNode.Next;
                                break;
                            }
                            else
                            {
                                beforeNode.Next = afterNode.Next;
                                afterNode = afterNode.Next;
                                break;
                            }
                        }
                        else
                        {
                            beforeNode = afterNode;
                            afterNode = afterNode.Next;
                        }
                    }
                }

            }

        }

        public bool IsEmpty()
        {
            return rootNode == null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty " + name);
            } // end if
            else
            {
                Console.Write("The " + name + " is: ");
                ListNode current = rootNode;
                
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                } 

                Console.WriteLine("\n");
            }
        } 

    }
}
