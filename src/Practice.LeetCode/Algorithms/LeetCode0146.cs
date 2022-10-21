namespace Practice.LeetCode.Algorithms;

public class LRUCache
{
    private readonly int capacity;
    private readonly Dictionary<int, Node> dictionary = new();
    private readonly DoubleList doubleList = new();

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (dictionary.TryGetValue(key, out var node))
        {
            doubleList.Remove(node);
            doubleList.AddFirst(node);
            return node.Value;
        }
        else
        {
            return -1;
        }
    }

    public void Put(int key, int value)
    {
        if (dictionary.TryGetValue(key, out var node))
        {
            doubleList.Remove(node);
            var newNode = new Node(key, value);
            dictionary[key] = newNode;
            doubleList.AddFirst(newNode);
        }
        else
        {
            if (doubleList.Count >= capacity)
            {
                var last = doubleList.RemoveLast();
                dictionary.Remove(last.Key);
            }

            var newNode = new Node(key, value);
            dictionary.Add(key, newNode);
            doubleList.AddFirst(newNode);
        }
    }

    private class Node
    {
        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }

        public int Key { get; private set; }

        public int Value { get; private set; }

        public Node Next { get; set; }

        public Node Previous { get; set; }
    }

    private class DoubleList
    {
        private readonly Node head = new(0, 0);
        private readonly Node tail = new(0, 0);

        public DoubleList()
        {
            head.Next = tail;
            tail.Previous = head;
        }

        public int Count { get; private set; }

        public void AddFirst(Node node)
        {
            var first = head.Next;
            first.Previous = node;
            node.Next = first;
            head.Next = node;
            node.Previous = head;
            Count++;
        }

        public Node RemoveLast()
        {
            if (Count == 0)
            {
                return default;
            }

            var last = tail.Previous;
            Remove(last);

            return last;
        }

        public void Remove(Node node)
        {
            var previous = node.Previous;
            var next = node.Next;
            previous.Next = next;
            next.Previous = previous;
            Count--;
        }
    }
}
