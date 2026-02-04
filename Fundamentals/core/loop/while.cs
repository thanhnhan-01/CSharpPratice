int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}

//

string input = "";

while (input != "exit")
{
    Console.Write("Enter text: ");
    input = Console.ReadLine();
}