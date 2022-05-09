﻿// See https://aka.ms/new-console-template for more information
using StackAndQueue;

Console.WriteLine("Welcome to Stack And Queue!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)Implementation of Stack Using LinkedList \n2)Implementation of Queue Using LinkedList");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            StackUsingLinkList value = new StackUsingLinkList();
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
            QueueusingLinkList Qvalue = new QueueusingLinkList();
            Qvalue.enqueue(56);
            Qvalue.enqueue(70);
            Qvalue.enqueue(30);
            Console.Write("Queue Values are : ");
            Qvalue.display();
            Console.WriteLine("\n***************************************************** ");
            break;
       default:
            break;
    }
}



