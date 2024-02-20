// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);


Random dice1 = new Random();
Random dice2 = new Random();
Random dice3 = new Random();
int roll_1 = dice1.Next(1, 7);
int roll_2 = dice2.Next(1, 7);
int roll_3 = dice3.Next(1, 7);
int total = roll_1 + roll_2 + roll_3;


Console.WriteLine($"Dice_1: {roll_1} + Dice_2: {roll_2} + Dice_3: {roll_3} = Total: {total}");

if ((roll_1 == roll_2) || (roll_1 == roll_3) || (roll_2 == roll_3))
{
    if ((roll_1 == roll_2) && (roll_1 == roll_3))
    {
        Console.WriteLine("You rolled triples");
        total += 6;
    }

    else
    {
        Console.WriteLine("You rolled doubles");
        total += 2;
    }
}


if (total >= 14)
{
    Console.WriteLine("You Won");
}

if (total >= 14)
{
    Console.WriteLine("You Won. Here is a trip for two");
}

if (total < 7)
{
    Console.WriteLine("You Won. Here is a laptop");
}

else 
{
    Console.WriteLine("You lost. Here is your cat");
}


string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("cat");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subsription has expired");
}

else if (daysUntilExpiration == 1)
{
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save 20%!");
    discountPercentage = 20;
}

else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
    discountPercentage = 10;
}

else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}


/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"first orderid: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second orderid: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third orderid: {fraudulentOrderIDs[2]}");


fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin:{bin} = {sum} items (Running total {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");

string[] fraudelentOrderIDs2 = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string risky in fraudelentOrderIDs2)
{ 
    if (risky.StartsWith("B"))
    {
        Console.WriteLine($"{risky} is a suspicious order");
    }
}


/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random2 = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random2.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random2.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(firstWord + " " + lastWord + "!");


/* The code converts the message str into a char array and then reverse the chars. 
   We then loop through all the chars in the reversed charMessage and add 1 to a variable
   that counts the amount of o's in the array. We then convert the chnaged array into a string again
   and prints out the new string and the amount of times o appears.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");