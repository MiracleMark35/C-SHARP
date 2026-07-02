const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";


int indexOfSpan = input.IndexOf("span");
int indexOfDiv = input.IndexOf(">");
int lastOfDiv = input.IndexOf("</div>");

indexOfSpan += 5;
indexOfDiv += 1;

int closingPosition = input.IndexOf("/span");
int length = closingPosition - indexOfSpan;
int length2 = lastOfDiv - indexOfDiv;

quantity = input.Substring( indexOfSpan, length - 1);
output =   input.Substring( indexOfDiv, length2 );

Console.WriteLine(quantity);
Console.WriteLine(output);