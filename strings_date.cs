Console.Write("Name: ");
var name = Console.ReadLine();

Console.Write("Surname: ");
var surname = Console.ReadLine();

Console.Write("Age: ");
var age = Console.ReadLine();

string message = $"The person named {name} {surname} is {age} years old.";

// var result = message.Length;
// var result = message.ToLower();
// var result = message.ToUpper();
// var result = message.Trim();
// var result = message.Split(" ")[0];
// var result = message[0];
// var result = message.StartsWith("B");
// var result = message.EndsWith(".");
// var result = message.Contains("Ali");
// var result = message.IndexOf("The");
// var result = message.Substring(4, 6);
var result = message.Replace("named","name");

Console.WriteLine(result);

// -----------------------------------

var now = DateTime.Now;

Console.WriteLine(now);
Console.WriteLine(now.Year);
Console.WriteLine(now.Month);
Console.WriteLine(now.Day);
Console.WriteLine(now.DayOfWeek);
Console.WriteLine(now.Hour);
Console.WriteLine(now.Minute);
Console.WriteLine(now.Second);

DateTime dt = new DateTime(2018, 6, 10, 14, 30, 45);
DateTime dt2 = dt.AddYears(1);
DateTime dt3 = dt.AddHours(2);

Console.WriteLine(dt2.Year);
Console.WriteLine(dt3.Hour);

var difference = now - dt;
Console.WriteLine(difference.TotalDays);