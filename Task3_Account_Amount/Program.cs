using Task3_Account_Amount.Classes;

class Program
{
    public static void Main()
    {
        AAList aalist = new();

        aalist.Add(123145939, 4243234);
        aalist.Add(432243432, 4532453);

        aalist.Show();

        BankList<int,double> bankList = new();

        bankList.Add(123145939, 4243234);
        bankList.Add(432243432, 4532453);

        bankList.Show();

        Console.ReadLine();
    }
}