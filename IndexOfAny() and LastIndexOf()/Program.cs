string message1 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition1 = message1.LastIndexOf('(');
openingPosition1 += 1;
int closingPosition1 = message1.LastIndexOf(')');
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message1.Substring(openingPosition1, length1));


string message2 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
// next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition2 = 0;

while (true) {
    int openingPosition2 = message2.IndexOfAny(openSymbols, closingPosition2);

    if (openingPosition2 == -1) break;

    string currentSymbol = message2.Substring(openingPosition2, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol) {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition2 += 1;
    closingPosition2 = message2.IndexOf(matchingSymbol, openingPosition2);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length2 = closingPosition2 - openingPosition2;
    Console.WriteLine(message2.Substring(openingPosition2, length2));
}