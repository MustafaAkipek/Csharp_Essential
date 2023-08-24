/*
    C# Data Types

    Value Types:
        Exact Number:     byte, short, int, long
        Decimal Number:   float, double, decimal
        Other Data Types: char, boolean, struct

    Reference Types:
        String, Class, Array, Interface

*/

/*
int number = 255;
float kdvRate = 1.18f; // decimal kdvOrani = 1.18m
char gender = 'M';
string gender2 = "Man";
string product_name = "Samsung S23";
bool sales_status = false;
*/

/*
    Data Type Convert

    1- Implicit Casting => Unconscious genre Transformation
    2- Explicit Casting => Concious Genre Transformation
*/

using System.Runtime.InteropServices;

int a = 10;
long b = a; // implicit casting

long d = 20;
int e = (int)d; // explicit casting

double f = 20.5;
float g = (float)f;

double h = 10.5;
int i = (int)h;

int x = 10;
string z = x.ToString();

Console.WriteLine(i);

// ---------------------------------------

Console.Write("1. Number: ");
var number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Number: ");
var number2 = Convert.ToInt32(Console.ReadLine());

var sum = number1 + number2;

Console.WriteLine(sum);

// Nullable Types

int? salary = null; // or default

Console.WriteLine(salary.HasValue);
Console.WriteLine(salary.GetValueOrDefault());