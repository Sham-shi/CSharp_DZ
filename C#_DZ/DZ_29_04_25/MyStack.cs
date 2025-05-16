

using System.Collections;

namespace C__DZ.DZ_29_04_25;

public class MyStack<T> : IEnumerable<T>
{
    private List<T> _stack;

    public void Push(T item)
    {
        _stack.Add(item);
    }

    public MyStack()
    {
        _stack = new List<T>();
    }

    public T Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Стек пуст");
        }

        var item = _stack[_stack.Count - 1];

        _stack.RemoveAt(_stack.Count - 1);

        return item;
    }

    public T Peek()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Стек пуст");
        }

        return _stack[_stack.Count - 1];
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in _stack)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
