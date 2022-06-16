using Microsoft.Data.SqlClient;
using MobileGroomersModels;

namespace MobileGroomersDL
{
    public class SQLStoreRepository : IRepository<Store>
    {

        //=================== Dependency Injection ==========================
        private string _connectionString;

        public SQLStoreRepository(string p_connectionString)
        {
            this._connectionString = p_connectionString;
        }

        //=====================Dependency Injection ========================
        public void Add(Store c_resources)
        {
            throw new NotImplementedException();
        }

        public List<Store> GetAll()
        {
            string sqlQuery = @"select * from Store";
            List<Store> listofCurrentStore = new List<Store>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listofCurrentStore.Add(new Store()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        //Products Need to add this in 
                    });
                }
            }

            return listofCurrentStore;
        }

        public Task<List<Store>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public void update(Store p_resources)
        {
            throw new NotImplementedException();
        }

        private List<Product> GetProductsFromAStore(int p_sId)
        {
            string SqlQuery = @"select s.sName, i.Quantity, p.pId, p.pName from Store s
                                    inner join Inventory i on s.sId = i.sId
                                    inner join Product p on i i.pId = p.pId
                                    where s.sId = @storeId";
            List<Product> listOfCurrentProduct = new List<Product>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(SqlQuery, con);

                command.Parameters.AddWithValue("@StoreId", p_sId);
                SqlDataReader reader = command.ExecuteReader(); 

                while (reader.Read())
                {
                    listOfCurrentProduct.Add(new Product(){
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
            }
            return listOfCurrentProduct;
        }
    }
}