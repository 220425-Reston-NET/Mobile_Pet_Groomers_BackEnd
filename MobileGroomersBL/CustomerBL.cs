using MobileGoomersModels;
using MobileGroomersDL;

namespace MobileGroomersBL
{
    public class CustomerBL : ICustomerBL
    {
        private IRepository<Customer> _CustomerRepo;

        public CustomerBL(IRepository<Customer> c_CustomerRepo)
        {
            _CustomerRepo = c_CustomerRepo;
        }
      
        public async void AddCustomer(Customer c_Customer)
        {
            Customer foundedCustomer = SearchCustomerByUserName(c_Customer.UserName);
            if (foundedCustomer == null)    
            {
                _CustomerRepo.Add(c_Customer);
            }
            else
            {
                throw new Exception("Customer UserName already exist!!");
            }
        }

        public List<Customer> GetCustomers()
        {
            return _CustomerRepo.GetAll();
        }

        public Customer SearchCustomerByAddress(string c_CustomerAddress)
        {
            List<Customer> currentListOfCustomer = _CustomerRepo.GetAll();
           
           foreach (Customer custobj in currentListOfCustomer)
           {
               if (custobj.Address == c_CustomerAddress)
               {
                   return custobj;
               }
           }
           
                return null;
        }

        public Customer SearchCustomerByUserName(string c_CustomerUserName)
        {
             List<Customer> currentListOfCustomers = _CustomerRepo.GetAll();
           
           foreach (Customer custobj in currentListOfCustomers)
           {
               if (custobj.UserName == c_CustomerUserName)
               {
                   return custobj;
               }
           
           
            }
                return null;
        }
    }
}