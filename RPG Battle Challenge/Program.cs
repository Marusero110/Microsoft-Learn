﻿int hero = 10;
int monster = 10;

Random dice = new();

do {
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health points and now has {monster} health points.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health points and now has {hero} health points.");
} while ((hero > 0) && (monster > 0));

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");