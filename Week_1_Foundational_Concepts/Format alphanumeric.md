# What is Composite Formatting?

Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.

This example of composite formatting uses a built-in method Format() on the string data type keyword. Update your code in the Visual Studio Code Editor as follows:

```csharp
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

// Output
World Hello!
Hello Hello Hello!
```

# String Interpolation

String interpolation is a technique that simplifies composite formatting.

```csharp
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Output
Hello World!
World Hello!
Hello Hello Hello!
```

# Formatting currency

Composite formatting and string interpolation can be used to format values for display given a specific language and culture. 

In the following example, the :C currency format specifier is used to present the price and discount variables as currency. 


```csharp
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Output
Price: ₱123.45 (Save ₱50.00)
```

# Format

```csharp
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

// Output
// Invoice Number: 1201
//    Shares: 25.457 Product
//      Sub Total: $2,750.00
//            Tax: 15.83%
//      Total Billed: $3,185.19
```


# Format Exercise

```csharp
using System;

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
// Moved the period before the \n here:
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.\n");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += $"{currentReturn:P2}".PadRight(15); // Changed to 15 for a bit more space
comparisonMessage += $"{currentProfit:C2}";
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += $"{newReturn:P2}".PadRight(15); // Changed to 15 for a bit more space
comparisonMessage += $"{newProfit:C2}";

Console.WriteLine(comparisonMessage);
```