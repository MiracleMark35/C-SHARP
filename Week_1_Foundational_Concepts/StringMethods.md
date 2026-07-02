# IndexOf()
IndexOf(): Looks into a string to find the position (index) of a specific character or phrase. If it finds it, it returns the position as an integer (remembering that computer counting starts at 0). If it can't find it, it returns -1.

# Substring()
Substring(): Extracts a smaller piece out of a larger string. You just have to tell it where to start cutting and, optionally, how many characters long you want that piece to be.

# LastIndexOf()

LastIndexOf() returns the index position of the last occurrence of a character or string within a given string. 

Both the Indexof() and LastIndexOf() methods return -1 if the character or string is not found.

```csharp
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

// Output
What if
more than
set of parentheses
```

# IndexOfAny()

IndexOfAny() reports the index of the first occurrence of any character in a supplied array of characters. The method returns -1 if all characters in the array of characters are not found.

```csharp
string message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
```


# Remove()

Remove() cuts out a chunk of text by its exact position (e.g., "Delete 20 characters starting at position 5").

# Replace()

Replace() swaps out specific text wherever it appears, like a find-and-replace tool (e.g., "Change every '-' into a space").

Replace() actually changes every single instance it finds in the string, not just the first one.
```csharp
string layout = "ID-99999[John Smith]Active";

// 1. Remove() - Cut out the ID prefix "ID-99999" (first 8 characters)
string noPrefix = layout.Remove(0, 8);

// 2. Replace() - Swap out brackets with clean spaces
string cleanData = noPrefix.Replace("[", " ").Replace("]", " ");

Console.WriteLine($"After Remove:  {noPrefix}");
Console.WriteLine($"After Replace: {cleanData}");

// Output
After Remove:  [John Smith]Active
After Replace:  John Smith Active
```

# Excercise format

```csharp
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);
```