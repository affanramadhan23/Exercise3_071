using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Linked_List_D
{
    class node
    {
        /*Creates Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public node next;
    }
    class CircularList
    {
        node LAST;
        node START;
        public CircularList()
        {
            LAST = null;
            START = null;
        }
        public void  InsertNode()
        {
            int nim;
            string nm;
            Console.Write("\nEnter The student identity number : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student : ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollNumber = nim;
            newnode.name = nm;
            if (START == null || nim <= START.rollNumber)
            {
                if ((START != null) && (nim == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            //Locate the postion of the new node in the list
            node previous, current;
            previous = START;
            current = START;

            while ((current != null) && (nim >= current.rollNumber))
            {
                if(nim == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                previous = current;
                current = current.next;
            }
            //*once the above for loop is executed, prev and current are positioned in such a manner that the position for the new node *//
            newnode = current;
            previous.next = newnode;
        }
        public bool Search(int rollNo, ref node previous, ref node current)
        /*Searches for the specified node*/
        {
            for (previous = current = LAST.next; current != LAST; previous = previous.next)
            {
                if (rollNo == current.rollNumber)
                    return (true); //returns true if the nodes is found
            }
            if (rollNo == LAST.rollNumber) //if the node is present at the end
                return (true);
            else
                return (false); //returns false if the node is not found 
        }
        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }
        public bool delNode(int nim)
        {
            node previous, current;
            previous = current = null;
            //check if the specified node is present in the list or not
            if (Search(nim, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }
        public void traverse() //Traverse all the nodes of the list
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\nRecords in the list are:\n");
                node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                {
                    Console.Write(currentNode.rollNumber + "   " + currentNode.name + "\n");
                    currentNode = currentNode.next;
                }
                Console.Write(LAST.rollNumber+ "   " + LAST.name + "\n");
            }
        }
        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
                Console.WriteLine("\nThe first record in the list:\n\n " + LAST.next.rollNumber + "    " + LAST.next.name);
        }
    }
}
namespace Exercise3_071
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
