
using System.Collections;

namespace Task4_OrderedDictionary
{
    public class OrderDic<T> : IEqualityComparer
    {
        private T[] _list = new T[0];


        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }
        public void Add(T element)
        {

            Array.Resize(ref _list, _list.Length + 1);
            _list[^1] = element;
        }

        public void Show()
        {
            foreach (T element in _list)
                Console.WriteLine(element);
        }
        public IEnumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        bool  IEqualityComparer.Equals(object? x, object? y)
        {
            if (x != null && y != null && x == y)
            {
                return true;
            }
            else { return false; }
        }

        int IEqualityComparer.GetHashCode(object obj) => (int)obj.GetHashCode();
 
        public int Count => _list.Length;

    }
}
