﻿string word = "snake";
string input = "There are snakes at the zoo";

Console.WriteLine(word);
Console.WriteLine(ReverseWord(word));
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseWord(string word) {
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) {
        result += word[i];
    }
    return result;
}

string ReverseSentence(string input) {
    string result = "";
    string[] words = input.Split(" ");
    foreach (string word in words) {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}