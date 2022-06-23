using Microsoft.Data.SqlClient;
using MobileGroomersModels;

namespace MobileGroomersDL
{
    public class SQLAppointmentsRepository : IRepository<Appointments>
    {
        private string _connectionString;
        
        public SQLAppointmentsRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;

        }
        public void Add(Appointments p_app)
        {
             string SQLQuery = @"insert into appointments
                                values (@CustName, @CustNumber, @PetName, @PetBreed, @ServiceName, @cId, @eId, @pId, @DateTime)";

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(SQLQuery, con);

                //We fill in the parameters we added earlier
                //We dynamically change information using AddWithValue and Parameters to avoid the risk of SQL Injection attack
                command.Parameters.AddWithValue("@CustName", p_app.CustName);
                command.Parameters.AddWithValue("@CustNumber", p_app.CustNumber);
                command.Parameters.AddWithValue("@PetName", p_app.PetName);
                command.Parameters.AddWithValue("@PetBreed", p_app.PetBreed);
                command.Parameters.AddWithValue("@ServiceName", p_app.ServiceName);
                command.Parameters.AddWithValue("@cId", p_app.cId);
                command.Parameters.AddWithValue("@eId", p_app.eId);
                command.Parameters.AddWithValue("@pId", p_app.pId);
                command.Parameters.AddWithValue("@DateTime", p_app.DateTime.Equals("YYYY-MM-DD hh:mm:ss"));


                //Execute sql statement that is nonquery meaning it will not give any information back (unlike a select statement)
                command.ExecuteNonQuery();
            }
        }
        public List<Appointments> GetAll()
        {
           string SQLQuery = @"select * from appointments";
           List<Appointments> listofapp = new List<Appointments>();

           using (SqlConnection con = new SqlConnection(_connectionString))
           {
               con.Open();

               SqlCommand command = new SqlCommand(SQLQuery, con);

               SqlDataReader reader = command.ExecuteReader();

               while (reader.Read())
               {
                   listofapp.Add(new Appointments(){
                       CustName = reader.GetString(1),
                       CustNumber = reader.GetInt64(2),
                       PetName = reader.GetString(3),
                       PetBreed = reader.GetString(4),
                       ServiceName = reader.GetString(5),
                       cId = reader.GetInt32(6),
                       eId = reader.GetInt32(7),
                       pId = reader.GetInt32(8),
                       DateTime= reader.GetDateTime(9)
                   });
               }

               return listofapp;
           }
        }

        public void Update(Appointments p_resource)
        {
            throw new NotImplementedException();
        }
    }
}