using System.ComponentModel.DataAnnotations;

namespace IdentityCoreSetup.Entities
{
    public class Rent
    {
        [Key] 
        public int _Id { get; set; }
        public string _CustomerName { get; set; }
        public decimal _AmountPaid { get; set; }
        public string _Arrears { get; set; }
        public string _Month { get; set; }
        public string _Receiver { get; set; }

    }
}
