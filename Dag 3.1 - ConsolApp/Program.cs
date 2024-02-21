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



for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}


