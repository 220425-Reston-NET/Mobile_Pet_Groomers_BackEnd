
namespace MobileGroomersUI
{
/// <summary>
/// Display MainMenu in application
/// </summary>
    public class MainMenu : IMenu
    {
        public void Display()
        {
           
            Console.WriteLine("How may I assist you today?");
            Console.WriteLine("[1] - Add a new customer");
            Console.WriteLine("[2] - Search Customer database");
            Console.WriteLine("[0] - Exit");
        }        
        
        public string Yourchoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                 return "AddCustomer";
            }
            else if (userInput =="2")
            {
                return "SearchCustomer";
            }
            
            
            else if (userInput == "0")
            {
                return "Exit";
            }
            else
            {
                Console.WriteLine("Please select a vaild response");
                return "MainMenu";
            }
        }
    }


}