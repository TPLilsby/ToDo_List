
//Varibles to input and output
string option;
string input;

//Varible to while loops
bool run = true;
bool repeat = true;

//Varibles to the list
List <string> todo = new List<string> ();


while (run)
{
    Console.WriteLine("\n Do you want to add something¨to your liast or see the list(add / see)");
    option = Console.ReadLine();

    if (option == "add")
    {
        while (repeat)
        {
            Console.WriteLine("\n Type somthing you want to add");
            input = Console.ReadLine();

            if (input == "q")
            {
                repeat = false;
            }

            todo.Add(input);
        }
    }
    else if (option == "see")
    {
        Console.Clear();
        todo.Remove("q");

        Console.WriteLine("Here are the list: ");

        foreach (string item in todo)
        {
            Console.WriteLine(item);
        }
    }
    else
    {
        Console.WriteLine("invalid input");
        run = false;
    }
}

