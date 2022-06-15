using MobileGroomersDL;
using MobileGroomersModels;

namespace MobileGroomersBL
{
    public class AppointmentsBL : IAppointmentsBL
    {

        //===============Dependancy Injection=====================

        private IRepository<Appointments> _AppRepo;
        public AppointmentsBL (IRepository<Appointments> p_AppRepo)
        {
            _AppRepo = p_AppRepo;
        }
        //======================================================
        public void AddAppointments(Appointments p_app)
        {
            Appointments foundedappointments = SearchAppointmentsByAppID(p_app.AppID);
            if (foundedappointments == null)
            {
                _AppRepo.Add(p_app);
            }
            else 
            {
                throw new Exception("Appointment already exists");
            }
        }

        public List<Appointments> GetAllAppointments()
        {
            return _AppRepo.GetAll();
        }

        public Appointments SearchAppointmentsByAppID(int p_app)
        {
            throw new NotImplementedException();
        }

        public void update(Appointments p_app)
        {
            throw new NotImplementedException();
        }
    }
}