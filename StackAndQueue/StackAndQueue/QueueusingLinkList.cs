using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueusingLinkList<M>
    {

        public int Count = 0;
        QNode<M>
        front, rear;

        public QueueusingLinkList()
        {
            this.front = this.rear = null;
        }
        public void enqueue(M Key)
        {
            Count++;
            QNode<M> temp = new QNode<M>(Key);


            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }
            this.rear.next = temp;
            this.rear = temp;

        }
        public void dequeue()
        {
            if (this.front == null)
            {
                return;

            }


            QNode<M> temp = this.front;
            this.front = this.front.next;


            if (this.front == null)
                this.rear = null;
            Count--;

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
                QNode<M> temp = front;
                while (temp != null)
                {

                    Console.Write("{0}->", temp.key);
                    temp = temp.next;
                }
            }
        }
    }

}
