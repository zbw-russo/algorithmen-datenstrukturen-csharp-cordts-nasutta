namespace SinglyLinkedListExample;

internal static class Program
{
    private static void Main()
    {
        var list = new SinglyLinkedList();

        list.Add("A");
        list.Add("B");
        list.Add("C");

        Console.WriteLine($"Count: {list.Count}");
        Console.WriteLine($"Contains B: {list.Contains("B")}");
        Console.WriteLine($"Item at index 1: {list[1]}");
        list[1] = "BB";
        Console.WriteLine($"Item at index 1: {list[1]}");
        Console.WriteLine($"Item at index 2: {list.FindByIndex(2)}");
        Console.WriteLine($"Remove BB: {list.Remove("BB")}");
        Console.WriteLine($"Contains BB: {list.Contains("BB")}");
        Console.WriteLine($"Count: {list.Count}");

        var stack = new Stack();

        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Console.WriteLine();
        Console.WriteLine($"Stack count: {stack.Count}");
        Console.WriteLine($"Stack peek: {stack.Peek()}");
        Console.WriteLine($"Stack pop: {stack.Pop()}");
        Console.WriteLine($"Stack pop: {stack.Pop()}");
        Console.WriteLine($"Stack count: {stack.Count}");

        stack.Clear();
        Console.WriteLine($"Stack count after clear: {stack.Count}");
    }
}
