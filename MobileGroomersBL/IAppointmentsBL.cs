using MobileGroomersModels;

namespace MobileGroomersBL
{
    public interface IAppointmentsBL
    {

        /// <summary>
        /// Add Appointments to the database
        /// </summary>
        /// <param name="p_app">This is the appointments object that will be added to the database</param>
        /// <returns>Gives back the Appointment that gets added to the DB</returns>
        void AddAppointments(Appointments p_app);
       
       
        /// <summary>
        /// This will display a list of appointments
        /// </summary>
        /// <returns>List of appointments</returns>

        List<Appointments> GetAllAppointments();


        /// <summary>
        /// This will search appointments in the DB by Name
        /// </summary>
        /// <param name="p_app">Name of appointments used to search </param>
        /// <returns>appointments searched</returns>

        Appointments SearchAppointmentsByAppID(int p_app);

        public void update (Appointments p_app);



    }
}