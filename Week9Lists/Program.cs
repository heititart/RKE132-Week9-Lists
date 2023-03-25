string folderPath = @"C:\data";
string fileName = @"shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();


if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else 
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}






static List<string> GetItemsFromUser() 
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add) / Exit (exit)");
        string userChoise = Console.ReadLine();

        if (userChoise == "add")
        {
            Console.WriteLine("Enter a item");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }

        else if (userChoise == "exit")
        {
            Console.WriteLine("Bye!");
            break;
        }

        else
        {
            Console.WriteLine("Invalid choice");
            break;
        }

    }

    return userList;

}


static void ShowItemsFromList(List<string> someLists) 
{
    Console.Clear();

    int listLength = someLists.Count;
    Console.WriteLine($" You have added {listLength} items to your shopping list.");

    int i = 1;

    foreach (string item in someLists)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}

