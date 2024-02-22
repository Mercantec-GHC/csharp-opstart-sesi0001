
using System;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


int[] data = new int[3];

/*
int first = 2;
string second = "4";
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

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");

/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
*/


string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

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
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
{
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
}
*/

/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal result = 0;
decimal total = 0;
string letters = "";

foreach (var value in values)
{
    if (decimal.TryParse(value, out result))
    {
        total += result;
    }
    else
    {
        letters += value;
    }
  
}

Console.WriteLine($"Total: {total}");
Console.WriteLine($"Message: {letters.Trim()}");
*/

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32(value1) / Convert.ToInt32(value2);

Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;

Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float) value1;

Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


/*
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

string[] pallets = { "B14", "A11", "B12", "A13" };
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

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


string value = "abc123";
char[] valueArray = value.ToCharArray();

Array.Reverse(valueArray);
//string valueReversed = new String(valueArray);
string valueReversed = string.Join(",", valueArray);
Console.WriteLine(valueReversed);

string[] valueResult = valueReversed.Split(",");

foreach (string result in valueResult)
{
    Console.WriteLine(result);
}



string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' ');
Console.WriteLine(words);

string pangramString = string.Join(",", words);
Console.WriteLine(pangramString);

char[] array = pangramString.ToCharArray();
Array.Reverse(array);
Console.WriteLine(array);

string pangramString2 = new string(array);
Console.WriteLine(pangramString2);

string[] pangramSplit2 = pangramString2.Split(",");
Console.WriteLine(pangramSplit2);

for (int i = (pangramSplit2.Length - 1); i >= 0; i--)
{
    string finalString = pangramSplit2[i];
    finalString += " ";
    Console.Write(finalString);
}


Console.WriteLine("");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderStreamArray = orderStream.Split(",");
Array.Sort(orderStreamArray);

foreach (var order in orderStreamArray)
{
    if (order.Length != 4)
    {
        Console.WriteLine($"-- {order}  Error");
    }

    else
    {
        Console.WriteLine($"-- {order}");
    }
}



string first4 = "Hello";
string second4 = "World";
string result4 = string.Format("{0} {1}!", first4, second4);
Console.WriteLine(result4);

Console.WriteLine("{1} {0}!", first4, second4);
Console.WriteLine("{0} {0} {0}!", first4, second4);

Console.WriteLine($"{first4} {second4}!");
Console.WriteLine($"{second4} {first4}!");
Console.WriteLine($"{first4} {first4} {first4}!");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N5} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");


decimal price3 = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("Your discount is: {0:C2}. of the original price: {1:C2}.", (price3 - salePrice), price3);
yourDiscount += $" A discount of {(price3 - salePrice) / price3:P2}!";

Console.WriteLine(yourDiscount);



int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");


string input = "Pad this";
Console.WriteLine(input.PadRight(12, '-'));


string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);


Console.WriteLine("");

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine("");
Console.WriteLine($"Currently, you own {currentShares} shares at a return of {currentReturn:P2}.");
Console.WriteLine("");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}");
Console.WriteLine("");
Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = $"{currentProduct}         {currentReturn:P2}   {currentProfit:C}";
string comparisonMessage2 = $"{newProduct}     {newReturn:P2}   {newProfit:C}";

// Your logic here

Console.WriteLine(comparisonMessage);
Console.WriteLine(comparisonMessage2);

