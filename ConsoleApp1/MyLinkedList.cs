using ConsoleApp8;
using System.Collections;

namespace ConsoleApp1;

public class MyLinkedList<T> : ICollection<T>
{
    public MyLinkedListNode<T> Head { get; set; }
    public MyLinkedListNode<T> Tail { get; set; }

    #region ICollection
    public int Count { get; private set; }

    public bool IsReadOnly { get => false; }

    public void Add(T item)
    {
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    #endregion

    #region Add

    public void AddFirst(MyLinkedListNode<T> node)
    {
        MyLinkedListNode<T> temp = Head;
        Head = node;
        Head.Next = temp;
        Count++;
        if (Count == 1)
            Tail = Head;
    }

    public void AddLast(MyLinkedListNode<T> node)
    {
      
        
        Tail.Next = node;
        Tail = node;
        Count++;
    }

    #endregion


    #region Remove

    public void RemoveFirst()
    {
       

        Head = Head.Next;
        Count--;

        if (Head == null)
            Tail = null;
    }

    public void RemoveLast()
    {

        if (Head == Tail)
        {
            Head = Tail = null;
            Count--;
            return;
        }

        MyLinkedListNode<T> temp = Head;

        while (temp.Next != Tail)
            temp = temp.Next;

        temp.Next = null;
        Tail = temp;
        Count--;
    }

    #endregion
}


