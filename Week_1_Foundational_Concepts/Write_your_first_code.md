# What is compilation?

A special program called a compiler converts your source code into a different format that the computer's central processing unit (CPU) can execute. 

When you used the ▶️ Run button in the previous unit, the code you wrote was first compiled, then executed.

The Console part is called a class. 

# The difference between Console.Write and Console.WriteLine

Console.WriteLine() prints text and moves to a new line.

Console.Write() prints text but stays on the same line.

# String Interpolation
```c#
string alice = "SADASDAS";
Console.WriteLine($"{alice} asdaI");
```

# Comment
```c#
// Console.WriteLine("Hello World!");
```

# Variable name examples

```c
char userOption;

int gameScore;

decimal particlesPerMillion;

bool processedCustomer;
```

Before you can use a variable, you have to declare it.
  
  To declare a variable, you first select a data type for the kind of data you want to store, and then give the variable a name that follows the rules.

# Variables using the var keyword must be initialized

The var keyword has an important use in C#. Many times, the type of a variable is obvious from its initialization. 

In those cases, it's simpler to use the var keyword. The var keyword can also be useful when planning the code for an application. When you begin developing code for a task, 

you may not immediately know what data type to use. Using var can help you develop your solution more dynamically.

# What is the .NET Class Library?

The .NET Class Library is a collection of thousands of classes containing tens of thousands of methods. For example, the .NET Class Library includes the Console class for developers working on console applications. 

The Console class includes methods for input and output operations such as Write(), WriteLine(), Read(), ReadLine(), and many others.

# How to call methods in the .NET Class Library

Start by typing the class name. In this case, the class name is Console.

Add the member access operator, the . symbol.

Add the method's name. In this case, the method's name is WriteLine.

Add the method invocation operator, which is a set of parentheses ().

Finally, specify the arguments that are passed to the method


# Stateful vs Stateless Methods in C#

## 1. Stateless Methods (Don't Remember Anything)

Stateless methods do their job and that's it. They don't need to remember any information from previous operations.

### Example

```csharp
Console.WriteLine("Hello");
```

`WriteLine()` doesn't need to remember anything from before.

Whether you call:

```csharp
Console.WriteLine("Hello");
Console.WriteLine("World");
```

or

```csharp
Console.WriteLine("Apple");
```

it works the same way.

It's called directly from the class:

```csharp
Console.WriteLine();
```

No object needs to be created first.

---

## 2. Stateful Methods (Remember Information)

Stateful methods need data stored inside an object.

### Example

```csharp
Random dice = new Random();
```

Here you're creating a `Random` object.

```csharp
int roll = dice.Next(1, 7);
```

The `Next()` method is stateful because it uses information stored inside the `dice` object.

### Think of `Random` Like a Person Rolling Dice

```csharp
Random dice = new Random();
```

Creates the person.

```csharp
dice.Next(1, 7);
```

Asks that person to roll the dice.

Without the person (`dice`), there is nobody to roll the dice.

This won't work:

```csharp
Random.Next(1, 7); // Error
```

because `Next()` belongs to an object, not directly to the class.

---

## Why Does Random Need State?

Imagine:

```csharp
Random dice = new Random();

Console.WriteLine(dice.Next(1, 7));
Console.WriteLine(dice.Next(1, 7));
Console.WriteLine(dice.Next(1, 7));
```

### Output

```text
4
2
6
```

The `Random` object keeps track of information internally so it can generate the next random number.

That internal information is called its **state**.

---

## Summary

| Stateless Method | Stateful Method |
|------------------|-----------------|
| Doesn't remember anything | Remembers information |
| Doesn't need an object | Needs an object |
| Called from the class | Called from an instance (object) |
| Example: `Console.WriteLine()` | Example: `dice.Next()` |

### Easy Rule

If you see:

```csharp
ClassName.MethodName();
```

Example:

```csharp
Console.WriteLine();
Math.Max(1, 2);
```

It's usually a **stateless (static)** method.

If you see:

```csharp
objectName.MethodName();
```

Example:

```csharp
dice.Next();
```

It's usually a **stateful (instance)** method.

# Creating an instance of a class

An instance of a class is called as an object. To create a new instance of a class, you use the new operator. 

Consider the following line of code that creates a new instance of the Random class to create a new object called dice:

```csharp
Random dice = new Random();
```

# Overloading
Think of overloading as giving the same method multiple ways to be called.

# What is a code block?

A code block is a collection of one or more lines of code that are defined by an opening and closing curly brace symbol { }.


# Array

Arrays can be used to store multiple values of the same type in a single variable.

# Declare a new array

To declare a new array of strings that can hold three elements, enter the following code:

```csharp
string[] fraudulentOrderIDs = new string[3];
```


# Looping through an array using foreach

```csharp
string[] kabaw = { "Rowena", "Robin", "Bao" };
foreach (string baka in kabaw)
{
    Console.WriteLine(baka);
}
```
```csharp
string [] codes = { "B123" ,"C234","A345","C15" ,"B177" ,"G3003" ,"C235" ,"B179"};

foreach( string item in codes)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}
```