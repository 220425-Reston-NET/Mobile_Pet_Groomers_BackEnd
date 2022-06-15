using Microsoft.Data.SqlClient;
using MobileGoomersModels;


namespace ShoeAppDL
{
    public class SQLCustomerRepository : IRepository<Customer>
    {
        private string _connectionString;

        public SQLCustomerRepository(string c_connectionString)

    {
        this._connectionString = c_connectionString;
    }
        public void Add(Customer c_resource)
        {
            string SQLQuary = @"insert into Customer
                               values (@custName, @custEmail, @custAddress, @custPhonenumber)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuary, con);

                command.Parameters.AddWithValue("@custName", c_resource.Name);
                command.Parameters.AddWithValue("@custEmail", c_resource.Email);
                command.Parameters.AddWithValue("@custAddress", c_resource.Address);
                command.Parameters.AddWithValue("@custPhonenumber", c_resource.Phonenumber);

                command.ExecuteNonQuery();
            }
        }

        public List<Customer> GetAll()
        {
            string SQLQuary = @"select * from Customer";

            List<Customer> listOfCustomer = new List<Customer>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuary, con);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listOfCustomer.Add(new Customer(){
                        CustomerID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Email = reader.GetString(2),
                        Address = reader.GetString(3),
                        Phonenumber = reader.GetString(4)
                    });
                }

                return listOfCustomer;
            }
        }

        public void Update(Customer c_resource)
        {
            throw new NotImplementedException();
        }
    }


}