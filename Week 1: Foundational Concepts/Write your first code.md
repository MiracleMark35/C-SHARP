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
