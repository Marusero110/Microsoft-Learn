string message = "The quick brown fox jumps over the lazy dog.";

// Check if the message contains "dog"
bool result = message.Contains("dog");
Console.WriteLine(result);

// Check if the message contains "fox"
if (message.Contains("fox")) {
    Console.WriteLine("What does the fox say?");
}
