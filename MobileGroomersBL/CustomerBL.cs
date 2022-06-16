using MobileGoomersModels;
using MobileGroomersBL;

namespace MobileGroomerBL
{
    public class CustomerBL : ICustomerBL
    {
        //===================================================
        private IRepository<Customer> _CustomerRepo;
        private global::MobileGroomersDL.CustomerRepository customerRepository;

        public CustomerBL(IRepository<Customer> C_CustomerRepo)
        {
            _CustomerRepo = C_CustomerRepo;
        }

        public CustomerBL(global::MobileGroomersDL.SQLCustomerRepository sQLCustomerRepository)
        {
            SQLCustomerRepository = sQLCustomerRepository;
        }

        public CustomerBL(global::MobileGroomersDL.CustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public global::MobileGroomersDL.SQLCustomerRepository SQLCustomerRepository { get; }

        //=======================================================
        public void AddCustomer(Customer c_Customer)
        {
            throw new NotImplementedException();
        }

        public Customer SearchCustomerByAddress(string c_CustomerAddress)
        {
            throw new NotImplementedException();
        }

        public Customer SearchCustomerByUserName(string c_CustomerUserName)
        {
            throw new NotImplementedException();
        }
    }
}