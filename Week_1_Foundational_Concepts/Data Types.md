# How To CHoose The Right Data Type

int for most whole numbers

decimal for numbers representing money

bool for true or false values

string for alphanumeric value

byte: working with encoded data that comes from other computer systems or using different character sets.

double: working with geometric or scientific purposes. double is used frequently when building games involving motion.

System.DateTime for a specific date and time value.

System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.

# Perform a cast
```csharp
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

float myFloat = (float)myDecimal;      // CAST
int myInt = (int)myDecimal;            // CAST
Console.WriteLine($"int: {myInt}");  // 3
```

# Use ToString() to convert a number to a string
```csharp
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message); // 57 String
```

# Convert a string to an int using the Parse() helper method

```csharp
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum); // 12 INT

```


# Convert a string to a int using the Convert class
```csharp
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result); // 35
```

# Compare casting and converting a decimal into an int
```csharp
int value = (int)1.5m; // casting truncates
Console.WriteLine(value); // 1 

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2); // 2
```

# TryParse() method

```csharp
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
```
# Exercise 
```csharp
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}"); //  Message: ABCDEF
Console.WriteLine($"Total: {total}");     //  Total: 68.3
```

# Conversion Math Exercise 

```csharp
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
```