namespace MobileGroomersModels
{
    public class Customer
    {
        // private int _customerID;

        //  public int CustomerID
        // {
        //     get { return _customerID;}
        //     set
        //     {
        //         if (value > 0)
        //         {
        //             _customerID = value;
        //         }
        //         else
        //         {
        //             throw new ValidationException("CustomerID needs to be above 0.");
        //         }
        //     }
        // }
    


        public string UserName {get; set;}
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {get; set; }
        public string City { get; set; }
        public string State { get; set; }


        public Customer()
        {
            
            UserName = "Sgray334";
            Password = "Fhrejdfn34!";
            FirstName = "Jeff";
            LastName = "Thomas";
            Address = "3454 Thomas St";
            City = "Arlington";
            State = "VA";
        }

    }
}