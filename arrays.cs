var courseName = "C# programming lessen with .net7".Split(' ');

string[] names = {"Ahmet", "Ali", "Canan", "Çınar", "Esra"};

int[] numbers = new int[5];

numbers[0] = 100;
numbers[1] = 200;
numbers[2] = 300;
numbers[3] = 400;
numbers[4] = 500;

Console.WriteLine($"Student number {numbers[0]}'s name is {names[0]}");

// Array Methods

string[] cities = {"Zonguldak", "Rize", "Kocaeli"};
int[] plates = {67, 53, 41};

cities.SetValue("Osmaniye", 0);

Console.WriteLine(cities.Length);
Console.WriteLine(cities.GetValue(0));
Console.WriteLine(Array.IndexOf(cities, "Osmaniye"));

Array.Sort(cities);
Array.Reverse(plates);
Array.Clear(plates, 1, 1);

Console.WriteLine(plates.GetValue(0));

// Slicing

string state = "Elazığ";
Console.WriteLine(state[0..3]);

// Multidimensional Arrays

string[] students = {"Mehmet", "Atakan", "Yaren"};
int[,] notes = new int[3,3];

notes[0,0] = 50;
notes[0,1] = 60;
notes[0,2] = 70;

notes[1,0] = 60;
notes[1,1] = 80;
notes[1,2] = 90;

notes[2,0] = 50;
notes[2,1] = 70;
notes[2,2] = 30;
