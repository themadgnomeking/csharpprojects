/*
int first = 2;
string second = "4";
//int result = first + second;
string result = first + second;
Console.WriteLine(result);
*/
/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
*/
/*
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
*/
/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"decimal: {myDecimal}");
Console.WriteLine($"float: {myFloat}");
*/
/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
*/
/*
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
*/
/*
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
*/
/*
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
*/
/*
string name = "Bob";
Console.WriteLine(int.Parse(name));
*/
/*
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

//Challenge - combine string arravy values https://learn.microsoft.com/en-us/training/modules/csharp-convert-cast/4-challenge



// Rule 1: if the value is alphanumeric, concatinate it to form a message
// Rule 2: if the value is numeric, add it to the total
// Rule 3: The result should match the following output
// Message: ABCDEF
// Total: 68.3
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0m;

foreach (var value in values)
{
    decimal number; 
    if (decimal.TryParse(value, out number))
    {
        
        total += number;
    }
    else
    {
        message += value;
        //Console.WriteLine(value);
    }
    
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");