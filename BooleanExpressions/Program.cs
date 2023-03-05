/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
*/
/*
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/
/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
*/
/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(pangram.Contains("cow"));
*/
/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/
/*

int salesAmount = 1001;

//int discount = salesAmount > 1000 ? 100 : 50;

//Console.WriteLine($"Discount: {discount}");
Console.WriteLine($"Discount: {(salesAmount > 1000 ? 100 : 50)}");
*/

//********* Challenge: https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/4-challenge-1
//use Randome class to generate a value
//Based on the value generated, use the conditional operator to display either heads or tails

/*
Random random = new Random();

int coinFlip = random.Next(1, 3);
string headsTailes = coinFlip > 1 ? "Tailes" : "Heads";

Console.WriteLine($"You flipped to a : {headsTailes}.");
*/

//Boolean Expressions challenge https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/6-challenge-2



string permission = "Manager";
int level = 19;

string outputMessage;
//Business Rules
// if user is admin with level greater than 55 output the message:
// "Welcome, Super Admin user."
if (permission.Contains("Admin") && level > 55)
{
    outputMessage = "Welcome, Super Admin user.";
}
// if user is Adminn with leverl less than or equal to 55, output the message:
// "Welcome, Admin user."
else if (permission.Contains("Admin") && level <= 55)
{
    outputMessage = "Welcome, Admin user.";
}
// if user is a Manager with lever 20 or greater, output the message:
// "Contact an Admin for access."
else if (permission.Contains("Manager") && level >= 20)
{
    outputMessage = "Contact an Admin for access.";
}
// if user is a Manager with a level less than 20, output the message:
// "You do not have sufficient priviliges."
else
{
    outputMessage = "You do not have sufficient priviliges.";
}
// if the user is not an Admin or a Manager, output the message:
// "You do not have sufficient privileges."

Console.WriteLine(outputMessage);