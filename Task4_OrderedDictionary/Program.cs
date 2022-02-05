using Task4_OrderedDictionary;

OrderDic<int> oDic = new OrderDic<int> { };

oDic.Add(13);
oDic.Add(13);

Console.WriteLine( Equals(oDic[0], oDic[1]) );

Console.ReadLine();