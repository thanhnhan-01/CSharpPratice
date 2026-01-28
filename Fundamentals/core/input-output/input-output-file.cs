/* 1 INPUT / OUTPUT advance with file */
// 1.1 Write text data to a file
File.WriteAllText("data.txt", "Hello File");

// 1.2 Read file
string content = File.ReadAllText("data.txt");
Console.WriteLine($"Content: {content}");

// 1.3. 
string[] lines = { "Line 1", "Line 2", "Line 3" };
File.WriteAllLines("list.txt", lines);

// 1.4
// 1. Get the runtime directory (bin/Debug/netX.X)
string runtimePath = AppContext.BaseDirectory;

// 2. Go up to the "Fundamentals" folder
// bin -> Debug -> netX.X -> project folder -> Fundamentals
string fundamentalsPath = Directory.GetParent(runtimePath)!
                                    .Parent!   // Debug
                                    .Parent!   // bin
                                    .Parent!   // project folder
                                    .FullName;

// 3. Build path to core/input-output/data
string dataFolderPath = Path.Combine(
    fundamentalsPath,
    "core",
    "input-output",
    "data"
);

// 4. Create the data folder if it does not exist
Directory.CreateDirectory(dataFolderPath);

// 5. Create file path
string filePath = Path.Combine(dataFolderPath, "data.txt");

// 6. Write file
File.WriteAllText(filePath, "Hello from Fundamentals!");

Console.WriteLine("File saved successfully!");
Console.WriteLine(filePath);

// 1.5
// The data folder is created inside the application's runtime directory
// provided by AppContext.BaseDirectory

// string basePath = AppContext.BaseDirectory;
// string dataFolder = Path.Combine(basePath, "data");

// Directory.CreateDirectory(dataFolder);

// string filePath = Path.Combine(dataFolder, "data.txt");
// File.WriteAllText(filePath, "Hello World");