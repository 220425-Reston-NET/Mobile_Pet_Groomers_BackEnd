using Microsoft.Data.SqlClient;
using MobileGoomersModels;


namespace MobileGroomersDL
{
    public class SQLCustomerRepository : IRepository<Customer>
    {
        //==============================================
        private string _connectionString;

        
        public SQLCustomerRepository(string c_connectionString)

    {
        this._connectionString = c_connectionString;
    }
    //====================================================
        public void Add(Customer c_resource)
        {
            string SQLQuary = @"insert into Customer
                               values (@CustName, @CustPassword, @CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustState)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuary, con);


                command.Parameters.AddWithValue("@CustName", c_resource.Name);
                command.Parameters.AddWithValue("@CustPassword", c_resource.Password);
                command.Parameters.AddWithValue("@CustFirstName", c_resource.FirstName);
                command.Parameters.AddWithValue("@CustLastName", c_resource.LastName);
                command.Parameters.AddWithValue("@CustAddress", c_resource.Address);
                command.Parameters.AddWithValue("@CustCity", c_resource.City);
                command.Parameters.AddWithValue("@CustState", c_resource.State);

                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAll()
        {
            string SQLQuary = @"select * from Customer";

            List<Customer> listOfCustomers = new List<Customer>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuary, con);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCustomers.Add(new Customer(){
                        Name = reader.GetString(1),
                        Password = reader.GetString(2),
                        FirstName = reader.GetString(3),
                        LastName = reader.GetString(4),
                        Address = reader.GetString(5),
                        City = reader.GetString(6),
                        State = reader.GetString(7),
                    });
                }

                return listOfCustomers;
            }
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