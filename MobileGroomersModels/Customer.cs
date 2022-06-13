namespace MobileGoomersModels
{
    public class Customer
    {
        public string UserName {get; set;}
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }
    }
        public Customer()
        {
            UserName = "Sgray334";
            Password = "Fhrejdfn34!";
            FirstName = "Jeff";
            LastName = "Thomas";
            Address = "3454 Thomas St";
            City = "Arlington";
            State = "VA";
            PhoneNumber = "718-347-7657";
            Orders = "Orders";
        }

}
