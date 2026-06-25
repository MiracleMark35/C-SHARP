# What is an expression?

An expression is any combination of values (literal or variable), operators, and methods that return a single value. 

A statement is a complete instruction in C#, and statements comprise one or more expressions. For example, the following if statement contains a single expression that returns a single value:

```csharp
if (myName == "Luiz")
```

#  outputs false
```csharp
Console.WriteLine("a" == "a ");
```

# What is the conditional operator?

The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false. 

The conditional operator is commonly referred to as the ternary conditional operator.

```csharp
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
```
# Example 1: 

```csharp
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
```

# Example 2:

```csharp
string permission = "Admin|Manager";
int level = 55;

Console.WriteLine($"{( permission.Contains("Admin")? 
level > 55? "Welcome, Super Admin user.": "Welcome, Admin user." 
:permission.Contains("Manager")? 
level > 22? "Contact an Admin for access.": 
"You do not have sufficient privileges.": "You do not have sufficient privileges.")}");
```

# Variable Scope

```csharp
// 1. Declare and initialize OUTSIDE the block
int value = 0; 

if (flag)
{
    // 2. You can safely change it or use it INSIDE the block
    value = 10; 
}

// 3. You can safely use it OUTSIDE the block because it was born outside!
Console.WriteLine(value); 

```

So, the rule of thumb is: Define and initialize your variables at the top level where you need them to be seen.

# Switch-case

```csharp
int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
```

# Exercise

```csharp
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

// 1. Switch for Product Type (index 0)
switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

// 2. Switch for Color (index 1)
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

// 3. Switch for Size (index 2)
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
```