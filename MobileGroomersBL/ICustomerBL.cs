using MobileGoomersModels;

namespace MobileGroomersBL
{
    public interface ICustomerBL
    {
        void AddCustomer(Customer c_Customer);

        Customer SearchCustomerByUserName(string c_CustomerUserName, string c_password);
        Customer SearchCustomerByAddress(string c_CustomerAddress);

        List<Customer> GetCustomers();



    }
}