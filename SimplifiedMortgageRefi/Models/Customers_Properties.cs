namespace SimplifiedMortgageRefi.Models
{
    public class Customers_Properties
    {

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int PropertyId { get; set; }

        public Property Property { get; set; }

    }
}