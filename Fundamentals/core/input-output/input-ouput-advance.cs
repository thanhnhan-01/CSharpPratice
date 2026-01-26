/* 1 INPUT / OUTPUT advance with data */
// 1.1. Split user input into multiple values
Console.Write("Enter numbers (comma separated): ");
string input = Console.ReadLine();

string[] parts = input.Split(',');

foreach (string part in parts)
{
    if (int.TryParse(part.Trim(), out int number))
    {
        Console.WriteLine($"Valid number: {number}");
    }
    else
    {
        Console.WriteLine($"Invalid input: {part}");
    }
}

// 1.2 Interactive menu using console input/output
while (true)
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("0. Exit");
    Console.Write("Choose: ");

    string choice = Console.ReadLine();

    if (choice == "0") break;

    Console.Write("Enter a: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter b: ");
    int b = int.Parse(Console.ReadLine());

    if (choice == "1")
        Console.WriteLine($"Result: {a + b}");
    else if (choice == "2")
        Console.WriteLine($"Result: {a - b}");
}
