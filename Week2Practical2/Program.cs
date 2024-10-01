using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;


static int MainMenu()
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");

    int choice = Convert.ToInt32(Console.ReadLine());
    return choice;
}


static void Task1()
{
    MainMenu();

    try
    {
        int choice = MainMenu();


        switch (choice)
        {
            case 1:
                Console.WriteLine("Bonjour");
                break;
            case 2:
                Console.WriteLine("Hola");
                break;
            case 3:
                Console.WriteLine("Hallo");
                break;
            case 4:
                Console.WriteLine("Cao");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error. {ex.Message}");
    }
}
