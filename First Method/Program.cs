﻿Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers() {
    Random random = new();

    for (int i = 0; i < 5; i++) {
        Console.Write($"{random.Next(1, 100)} ");
    }
}