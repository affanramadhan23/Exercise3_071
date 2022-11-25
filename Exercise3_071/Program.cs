﻿using System;
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