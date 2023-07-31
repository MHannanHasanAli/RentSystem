using System.ComponentModel.DataAnnotations;

namespace IdentityCoreSetup.Entities
{
    public class Customer
    {
        [Key]
        public int _Id { get; set; }
        public string _Name { get; set; }
        public string? _Address { get; set; }
        public string? _ContactNo { get; set; }
        public string? _Email { get; set; }
        public decimal _TotalRent { get; set; }
        public string _TypeOfRent { get; set; }
        public DateTime _NextDueDate { get; set; }
    }
}
