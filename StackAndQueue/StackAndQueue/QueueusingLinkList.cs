using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueusingLinkList
    {
       
        int Count = 0;
        QNode 
        front, rear;

        public QueueusingLinkList()
        {
            this.front = this.rear = null;
        }
        public void enqueue(int key)
        {
            QNode temp = new QNode(key);

            
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }
            this.rear.next = temp;
            this.rear = temp;
            Count++;

        }

        public void display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }
            else
            {
                QNode temp = front;
                while (temp != null)
                {

                    Console.Write("{0}->", temp.key);
                    temp = temp.next;
                }
            }
        }
    }
}
