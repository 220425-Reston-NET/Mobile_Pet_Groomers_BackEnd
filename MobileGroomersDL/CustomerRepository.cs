using System.Text.Json;
using MobileGoomersModels;

namespace MobileGroomersDL
{
    public class CustomerRepository : IRepository<Customer>
    {
        private string _filepath = "..MobileGroomersDL/Data/Customer.json";


        public void Add(Customer c_Customer)
        {
            List<Customer> listofcustomer = GetAll();
            listofcustomer.Add(c_Customer);

            string jsonString = JsonSerializer.Serialize(listofcustomer, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }


        public List<Customer> GetAll()
        {
            string JsonString = File.ReadAllText(_filepath);
            List<Customer> ListofCustomer = JsonSerializer.Deserialize<List<Customer>>(JsonString);

            return ListofCustomer;
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void update(Customer p_resources)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer p_resource)
        {
            throw new NotImplementedException();
        }
    }

}