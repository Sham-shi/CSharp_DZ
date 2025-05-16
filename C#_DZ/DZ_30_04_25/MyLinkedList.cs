using System.Collections;

namespace C__DZ.DZ_30_04_25;

public class MyLinkedList<T> : IEnumerable<T>
{
    private class Node<T>
    {
        public T? Value { get; set; }

        public Node<T>? Next { get; set; }
    }

    private Node<T>? _head;

    //private Node<T>? _tail;

    public int Count { get; private set; }

    public void Add(T data)
    {
        var node = new Node<T> { Value = data };

        if (_head == null)
        {
            _head = node;
        }
        else
        {
            var currentRoot = _head;

            while (currentRoot.Next != null)
            {
                currentRoot = currentRoot.Next;
            }
            
            currentRoot.Next = node;
        }

        Count++;
    }

    public bool Remove(T data)
    {
        var currentNode = _head;
        Node<T>? previosNode = null;

        while (currentNode != null)
        {
            if (currentNode.Value.Equals(data))
            {
                if (previosNode == null)
                {
                    _head = _head.Next;
                }
                else
                {
                    previosNode.Next = currentNode.Next;
                }

                Count--;
                return true;
            }

            previosNode = currentNode;
            currentNode = currentNode.Next;
        }

        return false;
    }

    public bool Contains(T data)
    {
        var currentRoot = _head;

        while (currentRoot != null)
        {
            if (currentRoot.Value.Equals(data))
            {
                return true;
            }

            currentRoot = currentRoot.Next;
        }

        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var currentRoot = _head;

        while (currentRoot != null)
        {
            yield return currentRoot.Value;
            currentRoot = currentRoot.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
