// 1.
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("i1 = " + i);
}

// 2.
for (int i = 10; i >= 0; i -= 2)
{
    Console.WriteLine("i2 = " + i);
}

// 3. For - Array
int[] numbers3 = { 10, 20, 30 };

for (int i = 0; i < numbers3.Length; i++)
{
    Console.WriteLine("For - Array: " + numbers3[i]);
}

// 4. Reverse Array
int[] numbers4 = { 1, 2, 3, 4, 5 };

for (int i = numbers4.Length - 1; i >= 0; i--)
{
    Console.Write(numbers4[i] + "\n");
}

// 5. Step Loop
int[] numbers5 = { 5, 10, 15, 20, 25, 30 };

for (int i = 0; i < numbers5.Length; i += 2)
{
    Console.WriteLine("Step Loop: " + numbers5[i]);
}

// 6. Filter
int[] numbers6 = { 3, 6, 9, 12, 15 };

for (int i = 0; i < numbers6.Length; i++)
{
    if (numbers6[i] % 2 == 0)
    {
        Console.WriteLine("Even numbers: " + numbers6[i]); // Print even numbers
    }
}

// 7. For - string
string text = "Hello";

for (int i = 0; i < text.Length; i++)
{
    Console.WriteLine("Text: " + text[i]);
}

// 8. Reverse String
string reverseString = "CSharp";

for (int i = reverseString.Length - 1; i >= 0; i--)
{
    Console.Write(reverseString[i]);
}

// 9. Count 
string text9 = "banana";
int count = 0;

for (int i = 0; i < text9.Length; i++)
{
    if (text9[i] == 'a')
    {
        count++;
    }
}

Console.WriteLine("\nCount: " + count); // 3

// 10. String Validation
string input = "12345";
bool isNumeric = true;

for (int i = 0; i < input.Length; i++)
{
    if (!char.IsDigit(input[i]))
    {
        isNumeric = false;
        break;
    }
}

Console.WriteLine(isNumeric);

// 11. 
int[] numbers11 = { 4, 7, 2, 9, 5 };
int max = numbers11[0];

for (int i = 1; i < numbers11.Length; i++)
{
    if (numbers11[i] > max)
    {
        max = numbers11[i];
    }
}

Console.WriteLine("Max: " + max);

// 12. Array - Nested Loop
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}

// 13. Matrix
// GetLength(0) → rows
// GetLength(1) → columns
int[,] matrix =
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

// 14. Foreach
int[] numbers14 = { 1, 2, 3 };

foreach (int n in numbers14)
{
    Console.WriteLine("Foreach: " + n);
}