﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//1. Escape Characters

// Q1: Write a program that prints the following text:
//Hello, "World!"
//Welcome to C# Programming.
//Make sure to include the quotes around "World!" and ensure "Welcome to C# Programming." appears on a new line.
Console.WriteLine("Hello, \"World!\"\nWelcome to C# Programming.");


//Q2: Write a C# program that prints the following file path using escape characters:
//C:\Users\JohnDoe\Documents\MyFile.txt
Console.WriteLine("c:\\users\\JohnDoe\\Documents\\MyFile.txt");


//2. Verbatim String Literals

//Q1: Rewrite the program from Q2 using a verbatim string literal (hint: use the @ symbol).
Console.WriteLine(@"c:\Users\JohnDoe\Documents\MyFile.txt");

//Q2: Write a program that uses a verbatim string literal to display a multi-line string like this:
//First Line
//Second Line
//Third Line
Console.WriteLine(@"First Line ");

//3. String Concatenation

//Q1: Write a program that asks the user for their first name and last name separately, then combines them into a full name and prints:
//Hello, [FullName]!
Console.Write("Enter Your First Name  ");
string FirstName = Console.ReadLine();

Console.Write("Enter Your Last Name  ");
string LastName = Console.ReadLine();

string FullName = FirstName + " " + LastName;
Console.WriteLine($"Hello, {FullName}!");

//Q2: Combine the following strings using the + operator and print the result:
//string part1 = "Learning ";
//string part2 = "C# is ";
//string part3 = "fun!";
//Expected Output: Learning C# is fun!
string part1 = "Learning ";
string part2 = "C# is ";
string part3 = "fun!";
Console.WriteLine(part1 + part2 + part3);

//4. String Interpolation

string? nameUser;
int ageUser;

Console.WriteLine("Your name please");
nameUser = Console.ReadLine();

Console.WriteLine("Your age please");
string? ageInput = Console.ReadLine();

try
{
    ageUser = Convert.ToInt32(ageInput); // Convert the string input to an integer
    Console.WriteLine($"Hello, {nameUser}! You are {ageUser} years old.");
}
catch (FormatException)
{
    Console.WriteLine("Invalid age input. Please enter a valid number.");
}

//Q2: Given two integers x = 15 and y = 25, use string interpolation to print their sum as part of the message:
//The sum of 15 and 25 is 40.
int x = 15 ;
int y = 25;
int z = x+y;
Console.WriteLine($"The sum of {x} and {y} is {z}.");

//5. Literal Strings


//Q1: Write a program that prints the string "Hello" without using any variables or string concatenation.
Console.WriteLine("Hello");
//Q2: Write a program that outputs the sentence "Learning C# at 7 PM!" using a string literal.
Console.WriteLine("Learning C# at 7 PM!");


//6. String Manipulation

//Q1: Write a program that asks the user for their name, and then prints the name in uppercase, lowercase, and with the first character capitalized (Title Case).
string? name1;
//string? user;
Console.WriteLine("Your name please");
name1 = Console.ReadLine();



//Q2: Write a program that takes a sentence and prints the number of characters in the sentence, excluding any spaces.


//7. String Formatting

//Q1: Write a program that prints the price of an item in currency format. Example:
//Price: $49.99   => Use string interpolation or String.Format().

//Q2: Write a program that takes a floating-point number and formats it to two decimal places using string interpolation.



//8. Escape Sequences

//Q1: Write a program that prints the following using the \t (tab) escape character:
//Name:    John
//Age:     30
//Country: USA

//Q2: Write a program that uses \n to print this text:
//Roses are red,
//Violets are blue,
//Sugar is sweet,
//And so are you!



//9. String Combination

//Q1: Create a C# program that combines three parts of a sentence using String.Join(). The parts are:
//"I am learning"
//"C# programming"
//"and it's awesome!" 
//Expected Output: I am learning C# programming and it's awesome!



//10. Substring and Indexing
//Q1: Write a program that takes a string "Hello, World!" and prints the substring "World".

//Q2: Write a program that asks the user for a sentence, then prints the first and last character of the sentence.



//11. String Parsing

//Q1: Write a program that converts the string "12345" into an integer and adds 10 to it. Print the result.

//Q2: Write a program that takes a date string in the format "MM/DD/YYYY" and extracts the month, day, and year, then prints them separately.



//12. String Methods

//Q1: Write a program that checks if the string "apple" is present in the sentence "I love eating apples!".

//Q2: Write a program that replaces every instance of the word "dog" with "cat" in the sentence "The dog chased the dog.".




//13. Special Character Handling

//Q1: Write a program that prints the following text without using escape characters
//He said, "It's a wonderful day!"  => (Hint: use verbatim string literal.)


//14. Advanced String Operations

//Q1: Write a C# program that asks the user for two words and prints the concatenation of the words in reverse order. For example, if the user enters "Hello" and "World", the program should print "WorldHello".