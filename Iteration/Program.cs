// Print 0 through 9 in ascending order
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
}

// Print 10 through 0 in descending order
for (int i = 10; i >= 0; i--) {
    Console.WriteLine(i);
}

// Print 0 through 9 in ascending order and increase i by 3 instead of 1
for (int i = 0; i < 10; i += 3) {
    Console.WriteLine(i);
}

// Print 0 through 7 in ascending order by adding a break statement for when i equals 7
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
    if (i == 7) break;
}

// Print an array of names in descending order
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--) {
    Console.WriteLine(names[i]);
}

// Print an array of names and replace "David" with "Sammy"
for (int i = 0; i < names.Length; i++) {
    if (names[i] == "David") names[i] = "Sammy";
}
foreach (var name in names) Console.WriteLine(name);