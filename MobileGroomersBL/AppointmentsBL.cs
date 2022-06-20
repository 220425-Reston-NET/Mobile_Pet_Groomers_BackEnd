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
        public void AddAppointments(Appointments p_AppID)
        {
                _AppRepo.Add(p_AppID);
        }

        public List<Appointments> GetAllAppointments()
        {
            return _AppRepo.GetAll();
        }

        public Appointments SearchAppointmentsByCustName(string p_app)
        {
            return _AppRepo.GetAll().First(Appointments => Appointments.CustName == p_app);
        }

        public void update(Appointments p_app)
        {
            throw new NotImplementedException();
        }
    }
}