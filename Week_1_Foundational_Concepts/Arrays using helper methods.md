# Array.Sort And Array.Reverse
```csharp
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets); / Sorted
// for Each
Sorted...
-- A11
-- A13
-- B12
-- B14

Reversed...
-- B14
-- B12
-- A13
-- A11
Array.Reverse(pallets); // reverse 
```

# Array.Clear(pallets, 0, 2);
```csharp
Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13
```

# Array.Resize() 
Is a method that allows you to add or remove elements from your array.
```csharp
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";


Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13

Resizing 6 ... count: 6
-- 
-- 
-- B12
-- A13
-- C01
-- C02
```

# Reverse a String
```csharp
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result); // 321cba

```

# String.Join( ? )
String.Join takes an array (or collection) of elements and glues them together into a single string, placing a separator of your choice between each element.
```csharp
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray); // 3,2,1,c,b,a
Console.WriteLine(result);

```
# String.Split( ? )
String.Split does the exact opposite. It takes a single string and chops it up into an array of smaller strings wherever it finds a specific separator.
```csharp
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
// Output
// 3
// 2
// 1
// c
// b
// a
```

# Reverse words in a sentence challenge
```csharp
string pangram  = "The quick brown fox jumps over the lazy dog";
string [] items = pangram.Split(' ');
string[] result1 = new string[items.Length];


for(int i = 0; i < items.Length; i++)
{
    char [] charArrays = items[i].ToCharArray();
    Array.Reverse(charArrays);
    string result = new string (charArrays);
    result1[i] = result;
}

   string Final = String.Join(" ", result1);

Console.WriteLine(Final);
// ehT kciuq nworb xof spmuj revo eht yzal god
```

# Parse a string of orders, sort orders and tag possible errors
```csharp
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}
```