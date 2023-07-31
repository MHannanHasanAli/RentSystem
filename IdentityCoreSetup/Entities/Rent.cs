using System.ComponentModel.DataAnnotations;

namespace IdentityCoreSetup.Entities
{
    public class Rent
    {
        [Key] 
        public int _Id { get; set; }
        public int _CustomerId { get; set; }
        public string _CustomerName { get; set; }
        public decimal _Amount { get; set; }
        public string _Type { get; set; }
        public DateTime _PaymentDate { get; set; }


    }
}
