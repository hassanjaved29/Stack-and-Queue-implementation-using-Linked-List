using System;
public class Node
{
    public int Data;
    public Node Next;
    public Node(int data)
    {
        Data = data;
    }
}
public class Stack
{
    private Node top;
    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = top;
        top = newNode;
    }
   public int Pop()
    {
        if (top == null)
        throw new InvalidOperationException("Stack is empty.");
        int value = top.Data;
        top = top.Next;
        return value;
    }
 public void Display()
    {
        for (Node current = top; current != null; current = current.Next)
            Console.Write(current.Data + " ");
        Console.WriteLine();
    }
}
public class Queue
{
    private Node front, back;
  public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (back != null) back.Next = newNode;
        else front = newNode;
        back = newNode;
    }
  public int Dequeue()
    {
        if (front == null)
        throw new InvalidOperationException("Queue is empty.");
        int value = front.Data;
        front = front.Next;
        if (front == null) back = null;
        return value;
    }
 public void Display()
    {
        for (Node current = front; current != null; current = current.Next)
            Console.Write(current.Data + " ");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(String [] args)
    {
        Console.WriteLine("Stack: ");
        Stack a1 = new Stack();
        a1.Push(10);
        a1.Push(20);
        a1.Push(30);
        a1.Display();
        Console.WriteLine("Pop from stack: " + a1.Pop());
        a1.Display();
        Console.WriteLine("\nQueue:");
        Queue b1 = new Queue();
        b1.Enqueue(10);
        b1.Enqueue(20);
        b1.Enqueue(30);
        b1.Display();
        Console.WriteLine("Dequeue from the queue: " + b1.Dequeue());
        b1.Display();
    }
}
