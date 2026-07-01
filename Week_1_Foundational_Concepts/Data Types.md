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

float myFloat = (float)myDecimal;
int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
```

# Use ToString() to convert a number to a string
```csharp
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
```

# Convert a string to an int using the Parse() helper method

```csharp
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

```


# Convert a string to a int using the Convert class
```csharp
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
```