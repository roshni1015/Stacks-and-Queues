// See https://aka.ms/new-console-template for more information
using StackAndQueue;

Console.WriteLine("Welcome to Stack And Queue!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)Implementation of Stack Using LinkedList \n2)Implementation of Queue Using LinkedList");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            StackUsingLinkList<int> value = new StackUsingLinkList<int>();
            value.push(70);
            value.push(30);
            value.push(56);
            Console.Write("Stack Values are : ");
            value.display();
            Console.WriteLine("\nTop element is {0} ", value.peek());
            Console.WriteLine("\n---------------------------------------------------- ");
            int length = value.Count;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("The top Element in stack is :" + value.peek());
                value.pop();
                Console.WriteLine("Number of elements in stack after pop method : " + value.Count);
            }
            Console.WriteLine("\n***************************************************** ");
            break;
        case 2:
            QueueusingLinkList<int> Qvalue = new QueueusingLinkList<int>();
            Qvalue.enqueue(56);
            Qvalue.enqueue(70);
            Qvalue.enqueue(30);
            Console.Write("Queue Values are : ");
            Qvalue.display();
            Console.Write("\n");
            Console.WriteLine("Number of elements in Queue : " + Qvalue.Count);
            Console.WriteLine("\n---------------------------------------------------- ");
            int length1 = Qvalue.Count;
            for (int i = 0; i < length1; i++)
            {
                Qvalue.dequeue();
                Console.WriteLine("Number of elements in Queue after Dequeue method : " + Qvalue.Count);
            }
            Console.WriteLine("\n***************************************************** ");
            break;
       default:
            break;
    }
}



