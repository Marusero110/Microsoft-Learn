// Use the equality operator

Console.WriteLine("a" == "a"); // Output: True
Console.WriteLine("a" == "A"); // Output: False
Console.WriteLine(1 == 2); // Output: False

string myValue = "a";
Console.WriteLine(myValue == "a"); // Output: True

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // Output: True


// Use the inequality operator

Console.WriteLine("a" != "a"); // Output: False
Console.WriteLine("a" != "A"); // Output: True
Console.WriteLine(1 != 2); // Output: True
Console.WriteLine(myValue != "a"); // Output: False


// Use the comparison operators

Console.WriteLine(1 > 2); // Output: False
Console.WriteLine(1 < 2); // Output: True
Console.WriteLine(1 >= 1); // Output: True
Console.WriteLine(1 <= 1); // Output: True


// Use a method that returns a Boolean

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // Output: True
Console.WriteLine(pangram.Contains("cow")); // Output: False


// Use the logical negation operator

Console.WriteLine(!pangram.Contains("fox")); // Output: False
Console.WriteLine(!pangram.Contains("cow")); // Output: True