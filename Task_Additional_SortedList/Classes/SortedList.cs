using System.Collections;

class SortedList<TKey, TValue> : ICollection
{
    private (TKey, TValue)[] _list = new (TKey, TValue)[0];

    public (TKey, TValue) this[int index]
    {
        get { return (_list[index]); }
        set { _list[index] = value; }
    }

    public void Add(TKey key, TValue value)
    {
        Array.Resize(ref _list, _list.Length + 1);

        _list[_list.Length - 1].Item1 = key;
        _list[_list.Length - 1].Item2 = value;

        if (_list.Length >= 3) Array.Sort(_list);
    }

    public void Show()
    {
        Console.WriteLine("Direct order:\n");
        foreach ((TKey, TValue) item in _list)
            Console.WriteLine(item);

        Console.WriteLine("\nReverse order:\n");
        foreach ((TKey, TValue) item in _list.Reverse())
            Console.WriteLine(item);
    }

    public int Count => ((ICollection)_list).Count;
    public bool IsSynchronized => _list.IsSynchronized;
    public object SyncRoot => _list.SyncRoot;
    public void CopyTo(Array array, int index)=>_list.CopyTo(array, index);
    public IEnumerator GetEnumerator() => _list.GetEnumerator();
    
}