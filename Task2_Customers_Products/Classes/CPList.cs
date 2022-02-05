using System.Collections;
using Task2_Customers_Products.Classes;

namespace Task2_Customers_Products
{

    class CPList
    {
        private Customer[] _listCustomer = new Customer[0];
        private Product[] _listProduct = new Product[0];

        public (Customer, Product) this[int index]
        {
            get { return (_listCustomer[index], _listProduct[index]); }
            set { (_listCustomer[index], _listProduct[index]) = value; }
        }
        public void Add(Customer customer, Product product)
        {
            Array.Resize(ref _listCustomer, _listCustomer.Length + 1);
            Array.Resize(ref _listProduct, _listProduct.Length + 1);
            _listCustomer[^1] = customer;
            _listProduct[^1] = product;
        }
        public void GetProducts(string customer)
        {
            for (int i = 0; i < _listCustomer.Length; i++)
            {
                if (_listCustomer[i].Name == customer)
                {
                    Console.WriteLine($"IdCard: {_listCustomer[i].IdCard} Customer: {_listCustomer[i].Name} " +
                                 $"{_listCustomer[i].Surname} \t\t" +
                                 $" Id: {_listProduct[i].Id} Product: {_listProduct[i].Name} " +
                                 $"Price: {_listProduct[i].Price}");
                }
            }
        }
        public void GetCustomers(string product)
        {
            for (int i = 0; i < _listProduct.Length; i++)
            {
                if (_listProduct[i].Name == product)
                {
                    Console.WriteLine($"IdCard: {_listCustomer[i].IdCard} Customer: {_listCustomer[i].Name} " +
                                 $"{_listCustomer[i].Surname} \t\t" +
                                 $" Id: {_listProduct[i].Id} Product: {_listProduct[i].Name} " +
                                 $"Price: {_listProduct[i].Price}");
                }
            }
        }

        public int Count =>  _listCustomer.Length;

    }


}
