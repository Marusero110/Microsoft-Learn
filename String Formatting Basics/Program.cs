// Composite formatting
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

Console.WriteLine();

// String interpolation
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

Console.WriteLine();

// Formatting currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

Console.WriteLine();

// Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

Console.WriteLine();

// Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

Console.WriteLine();

// Combining formatting approaches
price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);