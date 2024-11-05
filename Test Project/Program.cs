// Rolling a six-sided dice
Random dice1 = new();
int roll = dice1.Next(1, 7); // generates a random value between 1 and 6
Console.WriteLine($"You rolled a {roll}.");

// Rolling different forms of dice
Random dice2 = new();
int roll1 = dice2.Next();
int roll2 = dice2.Next(101); // generates a random value between 0 and 100
int roll3 = dice2.Next(50, 101); // generates a random value between 50 and 100
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// Returning the larger of two values
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine($"The larger value between {firstValue} and {secondValue} is {largerValue}.");

// Rolling three dice and summing the total
Random dice3 = new();
roll1 = dice3.Next(1, 7);
roll2 = dice3.Next(1, 7);
roll3 = dice3.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Check if the player rolled doubles or triples (see code between lines 21 and 27)
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    } else {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

// Check if the total (see code between lines 21 and 27) is greater than, equal to, or less than 15
if (total >= 15) {
    Console.WriteLine("You win!");
} else {
    Console.WriteLine("Sorry, you lose.");
}

// Reward the player with a prize depending on their total (see code between lines 21 and 27)
if (total >= 16) {
    Console.WriteLine("You win a new car!");
} else if (total >= 10) {
    Console.WriteLine("You win a new laptop!");
} else if (total == 7) {
    Console.WriteLine("You win a trip for two!");
} else {
    Console.WriteLine("You win a kitten!");
}

// Boolean expressions
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);
if (message.Contains("fox")) {
    Console.WriteLine("What does the fox say?");
}

// Renewal rate of subscriptions
Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
} else if (daysUntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
} else if (daysUntilExpiration == 1) {
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
} else if (daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired.");
}

if (discountPercentage > 0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

// Array example #1
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Array example #2
string[] names = ["Rowena", "Robin", "Bao"];
foreach (string name in names) {
    Console.WriteLine(name);
}

// Array example #3
int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;
foreach (int items in inventory) {
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

// Array challenge
string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string orderID in orderIDs) {
    if (orderID.StartsWith('B')) {
        Console.WriteLine(orderID);
    }
}
