/* 1 INPUT / OUTPUT advance with file */
// 1.1 Write text data to a file
File.WriteAllText("data.txt", "Hello File");

// 1.2 Read file
string content = File.ReadAllText("data.txt");
Console.WriteLine($"Content: {content}");

// 1.3. 
string[] lines = { "Line 1", "Line 2", "Line 3" };
File.WriteAllLines("list.txt", lines);