namespace MobileGroomersModels
{
    public class Services
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price {get; set; }


        public Services()
        {
            Id = 0;
            Title = "Default";
            Description = "Default";
            Price = 0;
        }
    }
}