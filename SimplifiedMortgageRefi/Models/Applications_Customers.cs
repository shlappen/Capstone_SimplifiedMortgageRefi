namespace SimplifiedMortgageRefi.Models
{
    public class Applications_Customers
    {
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}