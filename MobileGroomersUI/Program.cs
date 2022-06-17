// See https://aka.ms/new-console-template for more information

using MobileGroomersBL;
using MobileGroomersDL;
using MobileGroomersUI;

Console.WriteLine("Hello, World!");
Console.Clear();

IMenu menu = new MainMenu();

bool repeat = true;

while(repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.Yourchoice();

    // if (ans == "MainMenu")
    // {
    //     menu = new MainMenu();
    // }
    if (ans == "AddCustomer")
    {
        menu = new AddCustomer(new CustomerBL(new SQLCustomerRepository()));
    }
    // else if (ans == "SearchCustomer")
    // {
    //     menu = new SearchCustomerByUserName(new CustomerBL(new SQLCustomerRepository()));
    // }
    // else if (ans == "Exit")
    {
        repeat = false;
    }

}

