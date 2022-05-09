using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackUsingLinkList
    {

        Node top;
        public StackUsingLinkList()
        {
            this.top = null;

        }
        public void push(int x)
        {
            Node temp = new Node();
            if (temp == null)
            {
                Console.WriteLine("Heap overflow");
                return;
            }
            else
            {
                temp.data = x;
                temp.link = top;
                top = temp;
            }
            count++;
        }
        public bool isEmpty()
        {
            return top == null;
        }
        public int peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
        }
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            top = (top).link;
            count--;
        }
        private int count = 0;
        public int Count
        {
            get { return count; }
        }
        public void display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {

                    Console.Write("{0}->", temp.data);
                    temp = temp.link;
                }
            }
        }
    }
}
