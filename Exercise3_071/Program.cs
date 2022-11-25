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
        public CircularList()
        {
            LAST = null;
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
