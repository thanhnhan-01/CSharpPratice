while (true)
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Update");
    Console.WriteLine("3. Delete");
    Console.WriteLine("0. Exit");
    Console.WriteLine("---------");

    Console.Write("Choose: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Add item");
            break;
        case 2:
            Console.WriteLine("Update item");
            break;
        case 3:
            Console.WriteLine("Delete item");
            break;
        case 0:
            Console.WriteLine("Goodbye");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    if (choice == 0)
    {
        break;
    }
}