/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine("a" == "a ");
Console.WriteLine(1 == 2);

string myValue1 = "a";
string myValue2 = "A ";
Console.WriteLine(myValue1.Trim().ToLower() == myValue2.Trim().ToLower());
*/

using System;
using System.Linq;

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine(!pangram.Contains("dog"));

//< evaluate this condition > ? <if condition is true, return this value > : <if condition is false, return this value >

int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random random = new Random();
int randomNumber = random.Next(11);
Console.WriteLine($"The coin is: {(randomNumber % 2 == 0 ? "heads" : "tails")}");


string permission = "Admin|Manager";
int level = 15;



if (level <= 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Admin user.");
}

else if (level > 55 && permission.Contains("Admin"))
{
    Console.WriteLine("Welcome, Super Admin user.");
}

else if (level < 20 && permission.Contains("Manager"))
{
    Console.WriteLine("You do not have sufficient privileges.");
}

else if (level >= 20 && permission.Contains("Manager"))
{
    Console.WriteLine("Contact an Admin for access.");
}

else
{
    Console.WriteLine("You do not have sufficient privileges.");
}


int value = 0;
bool flag = true;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");



int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        found = true;
    }

}

if (found)
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");


int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";


switch (product[0])
{
    case "01":
        type = "Sweatshirt";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;

    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;

    default:
        type = "One size fits all";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");



for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
    if (i == 4)
    {
        break;
    }
}


string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "John";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}


for (int i = 0; i <= 100; i++)
{
    if ((i % 3) == 0 && (i % 5) == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }

    else if ((i % 3) == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }

    else if ((i % 5) == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }

    else
    {
        Console.WriteLine(i);
    }
}


Random randomly = new Random();
int current = randomly.Next(1, 11);

do
{
    current = randomly.Next(1, 11);

    if (current >= 8)
    {
        continue;
    }

    Console.WriteLine(current);
} while (current != 7);


/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = randomly.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");
*/


Random random2 = new Random();
int attack = random2.Next(0, 10);
int hero = 10;
int monster = 10;
int heroTurn = 0;
int monsterTurn = 1;

do
{
    if (monster > 0 && heroTurn < monsterTurn)
    {
        monster -= attack;
        if (monster <= 0)
        {
            Console.WriteLine($"The Hero won since the attack on the monster caused {attack} points damage resulting in the monster now having {monster} points");
            continue;
        }

        Console.WriteLine($"The attack on the monster caused {attack} point damage. The Monster now has {monster} points left.");
        heroTurn++;
    }

    else if (hero > 0 && monsterTurn <= heroTurn)
    {
        hero -= attack;
        if (hero <= 0)
        {
            Console.WriteLine($"The Monster won since the attack on the hero caused {attack} points damage resulting in the hero now having {hero} points");
            continue;
        }

        Console.WriteLine($"The attack on the hero caused {attack} point damage. The Hero now has {hero} points left.");
        monsterTurn++;
    }

    attack = random2.Next(0, 10);

} while (hero > 0 && monster > 0);


/*
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
*/


/*
string? userInput;
int numericInput = 0;
bool validEntry = false;
Console.WriteLine("Please enter a number between 5-10:");

do
{
    userInput = Console.ReadLine();
    validEntry = int.TryParse(userInput, out numericInput);

    if (numericInput >= 5 && numericInput <= 10)
    {
        Console.WriteLine($"Your number: {numericInput} has been accepted.");
        validEntry = true;
    }

    else
    {
        Console.WriteLine("Your input is out of scope. Please try again.");
        validEntry = false;
    }

} while (validEntry == false);
*/


string? userInput2;
string[] validRoles = { "Administrator", "Manager", "User" };
for (int i = 0; i < validRoles.Length; i++)
    validRoles[i] = validRoles[i].ToLower();

bool validEntry2 = false;

Console.WriteLine("Please enter the role that fit your position Administrator, Manager, or User");

do
{
    userInput2 = Console.ReadLine();
    userInput2 = userInput2.Trim().ToLower();


    if (validRoles.Contains(userInput2))
    {
        Console.WriteLine($"Your role as {userInput2} has been accepted");
        validEntry2 = true;
    }

    else
    {
        Console.WriteLine($"{userInput2} is not valid. Please enter one of the three valid positions");
        validEntry2 = false;
    }
} while (validEntry2 == false);



string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}