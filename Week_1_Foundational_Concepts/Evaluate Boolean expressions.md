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
```csharp
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
```