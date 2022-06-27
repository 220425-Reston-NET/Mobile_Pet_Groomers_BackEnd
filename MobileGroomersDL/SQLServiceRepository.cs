using Microsoft.Data.SqlClient;
using MobileGroomersModels;

namespace MobileGroomersDL      
{
    public class SQLServiceRepository : IRepository<Services>
    {
        //=======================================================
        private string _connectionString;
        public SQLServiceRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }
        //=======================================================
        public void Add(Services p_resource)
        {
           string SQLQuery = @"insert into Services
                                value (@ServTitle, @ServDescription, @ServPrice)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SQLQuery, con);

                command.Parameters.AddWithValue("@ServTitle", p_resource.Title);
                command.Parameters.AddWithValue("@ServDescription", p_resource.Description);
                command.Parameters.AddWithValue("@ServPrice", p_resource.Price);

                command.ExecuteNonQuery();
            }
        }

        public List<Services> GetAll()
        {
            string SQLQuary = @"select * from Services";
            List<Services> ListofServices = new List<Services>();
             using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuary, con);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListofServices.Add(new Services(){
                        Title = reader.GetString(1),
                        Description = reader.GetString(2),
                        Price = reader.GetString(3),
                        
                    });
                }

                return ListofServices;
            }
        }

        public void Update(Services p_resource)
        {
            throw new NotImplementedException();
        }
    }
}
