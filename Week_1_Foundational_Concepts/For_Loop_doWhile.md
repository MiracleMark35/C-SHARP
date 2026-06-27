# What is the for statement?



The for statement iterates through a code block a specific number of times. 

This level of control makes the for statement unique among the other iteration statements. 

The foreach statement iterates through a block of code once for each item in a sequence of data like an array or collection. 

The while statement iterates through a block of code until a condition is met.

# BASIC
```csharp

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
```

# Cant Update A VALUE During ForEACH

```csharp
string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}
```

# Overcoming the limitation of the foreach statement
```csharp
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
```
# Exercise
```csharp
for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}
```
# What is the do-while statement?

The do-while statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. 

Because that expression is evaluated after each execution of the loop, a do-while loop executes one or more times.
```csharp
do
{
    // This code executes at least one time
} while (true);
```


# Exercise
```csharp

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
```

# difference between do and while statement iterations

The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.

The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.

The do-while statement: conditionally executes its body one or more times.

The while statement: conditionally executes its body zero or more times.