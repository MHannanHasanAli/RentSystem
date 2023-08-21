using IdentityCoreSetup.Entities;

namespace IdentityCoreSetup.ViewModel
{
    public class RentViewModel
    {
        public class RentListingViewModel{
        public List<Rent> Rents { get; set; }
        public string SearchTerm { get; set; }
            public int _Id { get; set; }

        }

        public class RentActionViewModel
        {
            public List<Customer> Customer { get; set; }
            public List<string> Months { get; set; }
            public int _Id { get; set; }
            public string _CustomerName { get; set; }
            public decimal _AmountPaid { get; set; }
            public string _Arrears { get; set; }
            public string _Month { get; set; }
            public string _Receiver { get; set; }
        }
    }
}
