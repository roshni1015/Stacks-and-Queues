// See https://aka.ms/new-console-template for more information
using StackAndQueue;

Console.WriteLine("Welcome to Stack And Queue!");
StackUsingLinkList value = new StackUsingLinkList();
value.push(70);
value.push(30);
value.push(56);
Console.Write("Stack Values are ");
value.display();
Console.WriteLine("Top element is {0}\n", value.peek());
int length = value.Count;
for(int i = 0; i < length; i++)
{
    Console.WriteLine("The top Element in stack is :" + value.peek());
    value.pop();
    Console.WriteLine("Number of elements in stack after pop method : " + value.Count);
}



