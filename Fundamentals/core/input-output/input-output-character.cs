/* 1 INPUT / OUTPUT with Character */
// 1.1. Console.Read (Read reads a single character and returns its ASCII code)
Console.Write("Press a key: ");
int key = Console.Read();

Console.WriteLine($"\nASCII Code: {key}");

// 1.2. Console.ReadKey (ReadKey captures a key press without waiting for Enter)
Console.Write("Press any key...");
ConsoleKeyInfo keyInfo = Console.ReadKey();

Console.WriteLine($"\nYou pressed: {keyInfo.Key}");