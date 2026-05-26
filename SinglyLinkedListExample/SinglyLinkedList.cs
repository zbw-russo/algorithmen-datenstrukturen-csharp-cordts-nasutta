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
        var node = new Node { Data = item };
        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _tail.Link = node;
            _tail = node;
        }
        _count++;
    }

    public bool Contains(object item)
    {
        return Find(item) != null;
    }

    public bool Remove(object item)
    {
        var toBeDeleted = Find(item);
        if (toBeDeleted == null)
        {
            return false;
        }

        var previous = FindPrevious(toBeDeleted);
        if (previous == null)
        {
            _head = toBeDeleted.Link;
        }
        else
        {
            previous.Link = toBeDeleted.Link;
        }

        if (toBeDeleted == _tail)
        {
            _tail = previous;
        }

        _count--;
        return true;

    }

    public object FindByIndex(int index)
    {
        var node = FindByIndexInternal(index);
        return node?.Data;
    }

    private Node FindByIndexInternal(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }

        var current = _head;

        for (var i = 0; current != null; i++)
        {
            if (i == index)
            {
                return current;
            }

            current = current.Link;
        }

        return null;
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
        var current = _head;
        while (current != null) {
            if (current.Link == node)
            {
                return current;
            }
            current = current.Link;
        }
        return null;
    }
    public object this[int index]
    {
        get => FindByIndex(index);
        set
        {
            var node = FindByIndexInternal(index);
            if (node == null)
            {
                throw new IndexOutOfRangeException();
            }
            node.Data = value;
        }

    }
}
