
using System.Collections;

namespace Task3_Account_Amount.Classes
{
    public class BankList < TKey, TValue>
    {
        private TKey[] _listAccount = new TKey[0];
        private TValue[] _listAmount = new TValue[0];

        public (TKey, TValue) this[int index]
        {
            get { return (_listAccount[index], _listAmount[index]); }
            set { (_listAccount[index], _listAmount[index]) = value; }
        }
        public void Add(TKey key, TValue value)
        {
            Array.Resize(ref _listAccount, _listAccount.Length + 1);
            Array.Resize(ref _listAmount, _listAmount.Length + 1);
            _listAccount[^1] = key;
            _listAmount[^1] = value;
        }

        public void Show()
        {
            for (int i = 0; i < _listAccount.Length; i++)
            {
                Console.WriteLine($"Account: {_listAccount[i]} \t Amount: {_listAmount[i]} USD");
            }
            Console.WriteLine();
        }
        public IEnumerator GetEnumerator()
        {
            return _listAccount.GetEnumerator();
        }

        public int Count => _listAccount.Length;

    }
}
