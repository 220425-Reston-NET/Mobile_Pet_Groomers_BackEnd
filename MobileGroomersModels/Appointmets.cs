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
        public DateTime DateTime { get; set; }
        public string ServiceName { get; set; }
        public int cId { get; set;}
        public int eId { get; set;}
        public int pId { get; set; }

        DateTime dt = new DateTime(2018, 7, 23, 08, 20, 10);
        

        public Appointments()
        {
            AppID = 0;
            CustName = "Default";
            CustNumber = 9999999999;
            PetName = "Default";
            PetBreed = "Default";
            ServiceName = "Default";
            cId = 1233;
            eId = 331;
            pId = 4421;
        }
    }
}