using MobileGoomersModels;
using MobileGroomersBL;


public class AddCustomer : IMenu
{
    public static Customer customerobj = new Customer();

    //=====Dependency Injection Pattern=====
    private ICustomerBL _customerBL;
    public AddCustomer(ICustomerBL c_CustomerBL)
    {
        _customerBL = c_CustomerBL;
    }

    //======================================

    public void Display()
    {

        Console.WriteLine("Please enter the customers information by following the next few questions");
        Console.WriteLine("What is the Customer's Username?");
        customerobj.UserName = Console.ReadLine();
        Console.WriteLine("What is the Customer's Password?");
        customerobj.Password = Console.ReadLine();
        Console.WriteLine("What is the customer's First Name?");
        customerobj.FirstName = Console.ReadLine();
        Console.WriteLine("What is the Customer's Last Name?");
        customerobj.LastName = Console.ReadLine();
        Console.WriteLine("What is the Customer's Address?");
        customerobj.Address = Console.ReadLine();
        Console.WriteLine("Enter a City for the Address");
        customerobj.City = Console.ReadLine();
        Console.WriteLine("Enter a State for the Address. Only Two letters Please");
        customerobj.State = Console.ReadLine();


        Console.WriteLine("[1] - Add new Customer");
        Console.WriteLine("[0] - Exit");
    }

    public string Yourchoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Customer foundCustomer = _customerBL.SearchCustomerByUserName(customerobj.UserName);
            if (foundCustomer == null)
            {
                _customerBL.AddCustomer(customerobj);

            }
            return "MainMenu";
            try
            {
                _customerBL.AddCustomer(customerobj);
            }
            catch (System.Exception)
            {

                Console.WriteLine("Customer name already exist!");
                Console.ReadLine();
            }
        }
        else if (userInput == "0")
        {
            return "Exit";
        }
        else
        {
            Console.WriteLine("Please enter a correct response");
            return "AddCustomer";
        }
    }
}