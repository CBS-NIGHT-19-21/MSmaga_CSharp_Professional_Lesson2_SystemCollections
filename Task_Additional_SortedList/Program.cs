class Program
{
    public static void Main()
    {
        SortedList<int,string> list = new ();

        list.Add(1, "3!");
        list.Add(113, "19!");
        list.Add(19, "13!");
        list.Add(3, "9!");

        Console.WriteLine($"Number of elements: {list.Count}");

        list.Show();

        Console.ReadLine(); 
    }
}