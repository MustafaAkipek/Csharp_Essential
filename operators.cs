// Arithmetics Operators

    // var a = 10;
    // var b = 3;
    // var c = 2;

    // var result = a + b;
    // var result = a - b;
    // var result = a * b;
    // var result = (float)a / (float)b;
    // var result = (a + b) * c;
    // var result = a % b;
    // var result = a++;

    // Console.WriteLine(result);
    // Console.WriteLine(a);

// Nullable

    // int? d = 40;
    // int e = 20;

    // var res = (d ?? 0) + e;

    // Console.WriteLine(res);

    // // Console.Write("Number: ");
    // // int number = int.Parse(Console.ReadLine() ?? "0");
    // // var result = number % 2;

    // Console.WriteLine(result);

// Assign Operators

    // var f = 5;
    // var g = 10;

    // f += g; // f = f + g;
    // f += 5; // f = f + 5;
    // f -= g; // f = f - b;
    // f *= g; // f = f * g;
    // f /= g; // f = f / b;
    // f %= g; // f = f % g;

    // Console.WriteLine(f);

// Math Library

    // double result;

    // result = Math.Pow(2, 3);
    // result = Math.Sqrt(25);
    // result = Math.Abs(-10);
    // result = Math.Round(4.4);
    // result = Math.Floor(4.4);
    // result = Math.Ceiling(4.4);
    // result = Math.Max(10, 20);
    // result = Math.Min(10, 20);

    // Console.WriteLine(result);

// Comparison Operators

    // int a = 5, b = 5, c = 10, d = 3;
    // string username = "mustafaakipek";
    // string password = "482";


    // var result = (a == b); // true
    // result = (c == d);
    // result = (username == "mustafaakipek");
    // result = (password == "12345"); // false

    // result = (a != b);
    // result = (a > c);
    // result = (a < c);
    // result = (a >= b);

    // Console.WriteLine(result);

    // var res = (a > b) ? "a is bigger than b" : (a == b) ? "a is equal to b" : "b is bigger than a";

    // Console.WriteLine(res);

// Logical Operators

    // var a = true;
    // var b = true;
    // var c = false;
    // var d = false;

    // var result = (a && b);
    // result = (a && c);
    // result = (a && d);

    // result = (a || b);
    // result = (b || c);
    // result = (c || d);

    // result = !c;

    // Console.WriteLine(result);

// Random Library

string[] teams = {"Beşiktaş", "Galatasaray", "Fenerbahçe", "Trabzon"};

var rnd = new Random();

int number = rnd.Next(0, 4);

Console.WriteLine(teams[number]);