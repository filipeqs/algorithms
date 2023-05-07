namespace SinglyLinkedList;

public class Node
{
    public string Value { get; set; }
    public Node? Next { get; set; }
    
    public Node(string value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList
{
    public Node? Head { get; set; }
    public Node? Tail { get; set; }
    public int Length { get; set; }

    public LinkedList()
    {
        Head = null;
        Tail = null;
        Length = 0;
    }

    public LinkedList Push(string val) 
    {
        var node = new Node(val);

        if (Length == 0)
        {
            Head = node;
            Tail = node;
        }
        else 
        {
            var prevTail = Tail;
            prevTail!.Next = node;
            Tail = node;
        }

        Length++;
        return this;
    }

    public Node? Pop() 
    {
        if (this.Length == 0) return null;

        var current = Head;
        var newTail = current;
        while(current!.Next != null) 
        {
            newTail = current;
            current = current.Next;
        }

        newTail!.Next = null;
        Tail = newTail;
        Length--;
        if (Length == 0) this.Head = null;

        return current;
    }

    public LinkedList Reverse() 
    {
        var current = this.Head;
        this.Head = this.Tail;
        this.Tail = current;

        Node? prevNode = null;
        while(current != null) 
        {
            var nextNode = current.Next;
            current.Next = prevNode;
            prevNode = current;
            current = nextNode;
        }

        return this;
    }
}