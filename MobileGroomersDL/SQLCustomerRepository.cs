using Microsoft.Data.SqlClient;
using MobileGoomersModels;


namespace MobileGroomersDL
{
    public class SQLCustomerRepository : IRepository<Customer>
    {
        //==============================================
        private string _connectionString;

        public SQLCustomerRepository()
        {
        }

        public SQLCustomerRepository(string c_connectionString)

    {
        this._connectionString = c_connectionString;
    }
    //====================================================
        public void Add(Customer c_resource)
        {
            string SQLQuary = @"insert into Customers
                               values (@custUserName, @custPassword, @custFirstName, @custLastName, @custAddress, @custCity, @custState)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuary, con);


                command.Parameters.AddWithValue("@custUserName", c_resource.UserName);
                command.Parameters.AddWithValue("@custPassword", c_resource.Password);
                command.Parameters.AddWithValue("@custFirstName", c_resource.FirstName);
                command.Parameters.AddWithValue("@custLastName", c_resource.LastName);
                command.Parameters.AddWithValue("@custAddress", c_resource.Address);
                command.Parameters.AddWithValue("@custCity", c_resource.City);
                command.Parameters.AddWithValue("@custState", c_resource.State);

                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAll()
        {
            string SQLQuary = @"select * from Customers";

            List<Customer> listOfCustomers = new List<Customer>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuary, con);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCustomers.Add(new Customer(){
                        UserName = reader.GetString(1),
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

        
    }


}