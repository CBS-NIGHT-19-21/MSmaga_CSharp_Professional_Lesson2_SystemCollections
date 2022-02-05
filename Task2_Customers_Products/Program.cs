using Task2_Customers_Products;
using Task2_Customers_Products.Classes;

class Program
{
    public static void Main()
    {
        CPList list = new();

        list.Add(new Customer(123145939, "John", "Smith"),    new Product(234, "Cake", 2.75m));
        list.Add(new Customer(454933459, "David", "Rony"),    new Product(263, "Juice", 3.65m));
        list.Add(new Customer(134593942, "Peter", "Lee"),     new Product(454, "Juice", 3.65m));
        list.Add(new Customer(134519569, "Helen", "Jamsons"), new Product(774, "Milk", 1.15m));
        list.Add(new Customer(134593942, "Peter", "Lee"),     new Product(454, "Coffee", 2.85m));


        list.GetProducts("Peter");
        Console.WriteLine();

        list.GetCustomers("Milk");

        Console.ReadLine();
    }
}