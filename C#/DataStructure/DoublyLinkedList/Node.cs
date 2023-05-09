namespace DoublyLinkedList;

public class Node
{
    public string Value { get; set; }
    public Node? Next { get; set; }
    public Node? Prev { get; set; }

    public Node(string value) 
    {
        Value = value;
        Next = null;
        Prev = null;
    }
}