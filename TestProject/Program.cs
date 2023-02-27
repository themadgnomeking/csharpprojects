/*
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
*/

//int result = Random.Next();
/*
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
*/
/*
 Random dice = new Random();
 int roll1 = dice.Next();
 int roll2 = dice.Next(101);
 int roll3 = dice.Next(50, 101);

 Console.WriteLine($"First roll: {roll1}");
 Console.WriteLine($"Second roll: {roll2}");
 Console.WriteLine($"Third roll: {roll3}");

 dice.Next()
 */
/*
 int firstValue = 500;
 int secondValue = 600;
 int largerValue = Math.Max(firstValue, secondValue);
 Console.WriteLine(largerValue);
 */

 //if exercise https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/2-exercise-if
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
    
}



if (total >= 16)
{
    Console.WriteLine("You win $25,000!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a little kitteh!");
}
*/

// if/else challenge https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/4-challenge 

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
// Rule 1: Your code should only display one message
// Rule 2: If the users sub expries in 10 days or less display the message:
// "Your subscription will expire soon. Renew now!"
// Rule 3: If the users sub will exprie in five days or less, display the messages
// "Your subscription expries in _ days"
// "Renew now and save 10%!"
// Rule 4: if the users sub expires in one day, display the messages:
// "Your subscription expires within a day!"
// "Renew now and save 20%!"
// Rule 5: if the users sub has expried display the message:
// "Your subscription has expired"
// Rule 6: If the user  sub doesn't exprire in 10 days or less, display nothing

if (daysUntilExpiration > 10)
{
    Console.WriteLine("");
}
if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired");
    }
    else if (daysUntilExpiration == 1)
    {
        discountPercentage = 20;
        Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
    }
    else if (daysUntilExpiration <= 5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expries in {daysUntilExpiration} days!\nRenew now and save {discountPercentage}%!");
    }
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}