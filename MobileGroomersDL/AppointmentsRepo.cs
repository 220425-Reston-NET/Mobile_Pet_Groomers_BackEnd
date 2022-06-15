using MobileGroomersModels;

namespace MobileGroomersDL
{
    // This class is responsible for storing and reading data
    public class AppointmentsRepo : IRepository<Appointments>
    {
        List<Appointments> listofapp = new List<Appointments>();
        public void Add(Appointments p_app)
        {
            List<Appointments> listofapp = GetAll();
            listofapp.Add(p_app);
        }

        public List<Appointments> GetAll()
        {
            return listofapp;
        }

        public void Update(Appointments p_app)
        {
           List<Appointments> listofapp = GetAll();

           foreach (Appointments AppObj in listofapp)
           {

                if (AppObj.AppID == p_app.AppID)
                {
                    AppObj.AppID = p_app.AppID;
                }
            
           }
        }
    }
}

