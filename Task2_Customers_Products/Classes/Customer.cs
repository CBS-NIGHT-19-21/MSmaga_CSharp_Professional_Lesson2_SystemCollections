 

namespace Task2_Customers_Products.Classes
{
    public struct Customer
    {
        public long IdCard { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Customer(long idCard, string name, string surname)
        {
            IdCard = idCard;
            Name = name;
            Surname = surname;
        }
    }
}
