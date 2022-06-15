using System;

namespace MobileGroomersModels
{
    public class Appointments
    {
        public int AppID { get; set; }
        public string CustName { get; set; }
        public long CustNumber { get; set; }
        public string PetName { get; set; }
        public string PetBreed { get; set; }
        public object DateTime { get; set; }
        public string ServiceName { get; set; }

        DateTime dt = new DateTime(2018, 7, 23, 08, 20, 10);
        

        public Appointments()
        {
            AppID = 0;
            CustName = "Default";
            CustNumber = 0;
            PetName = "Default";
            PetBreed = "Default";
            DateTime = 0;
            ServiceName = "Default";
        }
    }
}