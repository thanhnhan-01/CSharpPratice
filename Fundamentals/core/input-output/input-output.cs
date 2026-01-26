/* 1. Output */
// 1.1 Console.WriteLine
Console.WriteLine("Hello World");
Console.WriteLine(0123456789);
Console.WriteLine(true);

// 1.2 Console.Write("Enter your name: "); -> Write outputs data without adding a new line

// 1.3 String Interpolation allows embedding variables inside strings
string name = "Smith";
int age = 23;

Console.WriteLine($"Name: {name}, Age: {age}");

// 1.4 Format date & number
double price = 12345.678;
DateTime today = DateTime.Now;

Console.WriteLine($"{price:N2}");     // 12,345.68
Console.WriteLine($"{price:C}");      // $12,345.68
Console.WriteLine($"{price:C0}");      // $12,346
Console.WriteLine($"{price:F}");      // 12345.68
Console.WriteLine($"{today:dd/MM/yyyy}");

/* 2. Output */
// 2.1. Console.ReadLine
Console.Write("Enter your name: ");
string yourName = Console.ReadLine();

Console.WriteLine($"Hello {yourName}");

// 2.2 TryParse
Console.Write("Enter your age: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int yourAge))
{
    Console.WriteLine($"Your age is {yourAge}");
}
else
{
    Console.WriteLine("Invalid age");
}

// 2.3
// Console.Write("Enter width: ");
int width = int.Parse(Console.ReadLine());

// Console.Write("Enter height: ");
int height = int.Parse(Console.ReadLine());

Console.WriteLine($"Area = {width * height}");