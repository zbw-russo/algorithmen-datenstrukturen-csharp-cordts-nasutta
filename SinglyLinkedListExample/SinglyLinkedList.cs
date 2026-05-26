namespace SinglyLinkedListExample;

public sealed class SinglyLinkedList
{
    private Node _head;
    private Node _tail;
    private int _count;

    public int Count => _count;

    public sealed class Node
    {
        public object Data { get; set; }
        public Node Link { get; set; }
    }

    public void Add(object item)
    {
        
    }

    public bool Contains(object item)
    {
        
    }

    public bool Remove(object item)
    {
        
    }

    public object FindByIndex(int index)
    {
        
    }

    private Node Find(object item)
    {
        var current = _head;

        while (current != null)
        {
            if (Equals(current.Data, item))
            {
                return current;
            }

            current = current.Link;
        }

        return null;
    }

    private Node FindPrevious(Node node)
    {
        
    }
}
