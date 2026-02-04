/* Type Casting */
/* 1. Implicit */
int a = 10;
double b = a;

Console.WriteLine("Implicit: " + b);

/* 2. Explicit */
double x = 9.7;
int y = (int)x; // 9

Console.WriteLine("Explicit: " + y);

/* 3. Convert */
string str = "123";
int numb = Convert.ToInt32(str);

Console.WriteLine("Convert Number: " + numb);

/* 4. */
// 4.1. int.parse
int n = int.Parse("456");
Console.WriteLine("Number: " + n); // crash

/* 4.2. TryParse (Recommend)
    TryParse attempts to convert a string to an integer.
    It returns true if the conversion succeeds; otherwise, it returns false.
    The result is returned via the out parameter.
*/

// a.
string input = "abc";
bool success = int.TryParse(input, out int result);

if (success)
{
    Console.WriteLine("Result: " + result);
}
else
{
    Console.WriteLine("Invalid!");
}

// b.
Console.Write("Enter your age: ");
string age = Console.ReadLine();

if (int.TryParse(age, out int result1))
{
    Console.WriteLine($"Your age is {result1} ");
}
else
{
    Console.WriteLine("Please enter a valid number");
}