namespace SinglyLinkedListExample;

public sealed class Stack
{
    private readonly SinglyLinkedList _items = new();

    public int Count => _items.Count;

    public void Push(object item)
    {
        _items.Add(new StackItem(item));
    }

    public object Pop()
    {
        var tailItem = GetTailItem();
        _items.Remove(tailItem);
        return tailItem.Value;
    }

    public object Peek()
    {
        return GetTailItem().Value;
    }

    public void Clear()
    {
        _items.Clear();
    }

    private StackItem GetTailItem()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        return (StackItem)_items[Count - 1];
    }

    private sealed class StackItem
    {
        public StackItem(object value)
        {
            Value = value;
        }

        public object Value { get; }
    }
}
