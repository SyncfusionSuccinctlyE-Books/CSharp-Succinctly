class Node<T>
{
    public T Item { get; set; }
    public Node<T> Next;

    public Node(T item)
    {
        Item = item;
    }
}