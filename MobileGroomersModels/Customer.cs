namespace MobileGoomersModels
{
    public class Customer
    {
        public string Name {get; set;}
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {get; set; }
        public string City { get; set; }
        public string State { get; set; }


        public Customer()
        {
            
            Name = "Sgray334";
            Password = "Fhrejdfn34!";
            FirstName = "Jeff";
            LastName = "Thomas";
            Address = "3454 Thomas St";
            City = "Arlington";
            State = "VA";
        }

    }
}