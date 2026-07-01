string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string [] splitted = orderStream.Split(",");
Array.Sort(splitted);
for (int i = 0; i < splitted.Length; i++)
{
    char[] message = splitted[i].ToCharArray();
        string displayWord = new string(message);    
        if (message.Length == 4)
    {
        Console.WriteLine($"{displayWord}");
    }
    else
    {
        Console.WriteLine($"{displayWord}\t- Error");
    }

}