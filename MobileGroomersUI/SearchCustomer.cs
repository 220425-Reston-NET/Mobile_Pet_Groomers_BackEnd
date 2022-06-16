// using MobileGoomersModels;
// using MobileGroomersBL;

// public class SearchCustomer : IMenu
// {

//     private ICustomerBL _custBL;
//     public SearchCustomer(ICustomerBL c_customerBL)
//     {
//         _custBL = c_customerBL;
//     }
//     public void Display()
//     {
//         Console.WriteLine("How would you like to look up the Customers Information?");
//         Console.WriteLine("[1] - Search by UserName");
//         Console.WriteLine("[3] - Search by Address");
    
//         Console.WriteLine("[6] - Exit");

//     }

//     public string Yourchoice()
//     {
//         string userInput = Console.ReadLine();

//         if (userInput == "1")
//         {
//             Console.WriteLine("Enter a valid Customer Name:");
//             string custName = Console.ReadLine();
            
//             Customer foundedCustomer = _customerBL.SearchCustomerByUserName(custUserName);

//             if (foundedCustomer == null)
//             {
//                 Console.WriteLine("Customer Not Found!!");
//             }
//             else
//             {
//                 Console.WriteLine("====Customer Info====");
//                 Console.WriteLine("UserName: "+ foundedCustomer.UserName);
//                 Console.WriteLine("Address:" + foundedCustomer.Address);
//                 Console.WriteLine("====================");
                
                
              
                    
//             }
//             Console.ReadLine();
//             return "SearchCustomer";


            
           
            
//         }
//         else if (userInput == "2")
//         {
//             Console.WriteLine("Enter a valid User Name:");
//             string CustomerUserName = Console.ReadLine();
            

//             return "MainMenu";
//         }
//         else if (userInput == "3")
//         {
//             Console.WriteLine("Enter a valid Address:");
//             string customerAddress = Console.ReadLine();

//             return "MainMenu";
//         }
//     }    
// }