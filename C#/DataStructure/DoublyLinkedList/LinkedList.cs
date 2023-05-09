namespace DoublyLinkedList;

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
        var newNode = new Node(val);

        if (Length == 0)
        {
            Head = newNode;
            Tail = newNode;
        }
        else 
        {
            var prevTail = Tail;
            prevTail!.Next = newNode;
            newNode.Prev = prevTail;
            Tail = newNode;
        }

        Length++;

        return this;
    }

    public Node? Pop()
    {
        if (Length == 0) return null;

        var prevTail = Tail;

        Tail = prevTail!.Prev;

        if (Tail != null)
            Tail.Next = null;

        Length--;
        if (Length == 0)
            Head = null;

        return prevTail;
    }

    public LinkedList Reverse() 
    {
        var current = Head;
        Head = Tail;
        Tail = current;

        Node? prev = null;
        Node? next = current?.Next;

        while (current != null)
        {
            var nextNode = current.Next;
            current.Next = prev;
            current.Prev = next;

            current = nextNode;
            if (current != null)
            {
                prev = current.Prev;
                next = current.Next;
            }            
        }

        return this;
    }
}