// Question: Is it possible that attempting to change the value's data type would throw an exception at run time?

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result); // The result is 24, not 6.

Console.WriteLine();

// Question: Is it possible that attempting to change the value's data type would result in a loss of information?

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}"); // The value of myDecimal is the same as myInt.

Console.WriteLine();

// Performing a cast

myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

Console.WriteLine();

// "Widening conversion" or "narrowing conversion"?

myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

Console.WriteLine();

// Performing a data conversion

int firstInt = 5;
int secondInt = 7;
string message = firstInt.ToString() + secondInt.ToString();
Console.WriteLine(message);

Console.WriteLine();

// Using the Parse() helper method

string firstString = "5";
string secondString = "7";
int sum = int.Parse(firstString) + int.Parse(secondString);
Console.WriteLine(sum);

Console.WriteLine();

// Using the Convert class

string value1 = "5";
string value2 = "7";
int resultValue = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(resultValue);

Console.WriteLine();

// Casting vs. converting a decimal into an int

int newValue = (int)1.5m; // casting truncates
Console.WriteLine(newValue);

int newValue2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(newValue2);