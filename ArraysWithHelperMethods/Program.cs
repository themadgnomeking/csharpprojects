﻿/*
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");


Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach( var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
/*
// Excersize - Discover Split() and Join()
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string [] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

// Challenge - reverse words - https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/5-challenge-1

string pangram = "The quick brown fox jumps over the lazy dog";
string[] splitSentence = pangram.Split(" ");

string outputSentance = "ehT kciuq nworb xof spmuj revo eht yzal god";

char[] pangramArray = pangram.ToCharArray();
Array.Reverse(pangramArray);
string result = new string(pangramArray);
string[] items = result.Split(' ');
Array.Reverse(items);
string finalSentance = String.Join(" ", items);


if (finalSentance == outputSentance)
{
    Console.WriteLine(finalSentance);
} else 
{
    Console.WriteLine("Try again!");
}

