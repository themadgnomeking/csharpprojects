/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");


do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);
*/
/*
Random random = new Random();

int player = 10;
int monster = 10;
int attacks = random.Next(1, 11);

bool heroTurn = true;

while (player > 0 || monster > 0)
{
    attacks = random.Next(1, 11);
    if (heroTurn == true)
    {
        
        monster -= attacks;
        Console.WriteLine($"Monster's health is {monster} and lost {attacks} HP.");
        heroTurn = false;
        if (monster <= 0)
        {
            Console.WriteLine("Player wins!");
            break;
        }
    }
    else
    {
        player -= attacks;
        Console.WriteLine($"Players's health is {monster}");
        heroTurn = true;
        if (player <= 0)
        {
            Console.WriteLine("Monster Wins!");
            break;
        }
    }
}
*/

//****************Code Project 1 - write code that validates integer input
/*
Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value is not between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/


//****************Code Project 2 - write code that validates string input
/*
our solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and training space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered is not a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/


//****************Code project 3 - Write code in the code editor to implement code that achieves the project conditions 