decimal value1 = 0m;
string message = "4.21312";


Console.WriteLine(decimal.TryParse(message ,out value1));
Console.WriteLine(value1);
