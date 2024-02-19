Console.WriteLine("Hello World");
//Console.WriteLine("Hello, World!");


Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");


Console.WriteLine(" ");
Console.WriteLine("This is the first line");
Console.Write("This is the ");
Console.Write("Second line");


Console.WriteLine(" ");
Console.WriteLine('b');
//Console.WriteLine('Hello World!');

Console.WriteLine(123);
Console.WriteLine(0.25f);
Console.WriteLine(2.625);
Console.WriteLine(12.39816m);


Console.WriteLine(" ");
Console.WriteLine(true);
Console.WriteLine(false);


Console.WriteLine("123");
Console.WriteLine(123);
Console.WriteLine("true");
Console.WriteLine(true);


//string firstName;

char genderOption;
int calenderYear;
decimal particleSpeedPerMillion;
bool godsExistence;


string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "John";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Martin";
Console.WriteLine(firstName);

string lastName = "Rasmussen";
Console.WriteLine(lastName);


var message = "Hello World";
Console.WriteLine(message);


string dogsName = "Figgo";
int dogsAge = 3;
decimal dogsTemperature = dogsTemperature= 34.5m;

Console.Write("Here is ");
Console.Write(dogsName);
Console.Write(". He is ");
Console.Write(dogsAge);
Console.Write(" years old. ");
Console.Write("His bodytempeture is ");
Console.Write(dogsTemperature);


Console.WriteLine(" ");
Console.WriteLine("Hello \nWorld");
Console.WriteLine("Hello \tWorld");
Console.WriteLine("Hello World \"not wordle\".");
Console.WriteLine("Hello World \\not wordle");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"c:\invoices");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");


string catsName = "Leo";
string greetting = "Hello";
Console.WriteLine(greetting + " " + catsName + " ");

int strangersAge = 23;
string politeStatement = "You don't look like";
Console.WriteLine($"{politeStatement} {strangersAge}");

string programName = "First-Project";
Console.WriteLine($@"C:\Output\{programName}\Data");


string projectName = "ACME";
//View Russian output
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishMessage = "View english output:";
Console.WriteLine(englishMessage + "\n\t\t" + $@"c:\Exercise\{projectName}\data.txt");
Console.WriteLine(russianMessage + "\n\t\t" + $@"c:\Exercise\{projectName}\ru-RU\data.txt");

string exampleName = "Bob";
int firstNumber = 4;
int secondNumber = 9;
Console.WriteLine(exampleName + " is " + (secondNumber + 7) + " years old");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
decimal decimalQuotient = 7.0m / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal Quotient = (decimal)first / (decimal)second;
Console.WriteLine(Quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);


int valueExample = 0;     
valueExample = valueExample + 5; 
valueExample += 5;
Console.WriteLine(valueExample);

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

int value3 = 1;
value3++;
Console.WriteLine("First: " + value3);
Console.WriteLine($"Second: {value3++}");
Console.WriteLine("Third: " + value3);
Console.WriteLine("Fourth: " + (++value3));

int fahrenheit = 94;
decimal temperatureConversion = (fahrenheit - 32) * (5/9m); 
Console.WriteLine($"The temperature converted from fahrenheit is: {temperatureConversion} celsius");

