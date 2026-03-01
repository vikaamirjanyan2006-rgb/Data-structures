

using ConsoleApp1;
using ConsoleApp8;
using MyStack;

MyLinkedListNode<int> first = new MyLinkedListNode<int>(1);
MyLinkedListNode<int> second = new MyLinkedListNode<int>(2);
MyLinkedListNode<int> third = new MyLinkedListNode<int>(3);
MyLinkedListNode<int> fourth = new MyLinkedListNode<int>(4);
MyLinkedListNode<int> fifth = new MyLinkedListNode<int>(5);
MyLinkedList<int> list = new MyLinkedList<int>();

list.AddFirst(first);
list.AddFirst(second);
list.AddFirst(fourth);
list.AddLast(third);
list.AddLast(fifth);
list.RemoveFirst();
list.RemoveLast();
Console.WriteLine(list.Tail.Value);
MyStack<int> stack = new MyStack<int>();


stack.Push(90);
stack.Push(7);
stack.Push(67);
stack.Push(88);
stack.Push(3);

Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");
Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");
Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Pop: {stack.Pop()}");