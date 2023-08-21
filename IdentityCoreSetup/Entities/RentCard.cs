using System.ComponentModel.DataAnnotations;

namespace IdentityCoreSetup.Entities
{
    public class RentCard
    {
        [Key]
        public int _Id { get; set; }
        public string _NameOfTenant { get; set; }
        public string _BusinessPlace { get; set; }
        public string _ContactNo { get; set; }
        public string _EmergencyName { get; set; }
        public string _EmergencyTel { get; set; }
        public string _NameOfLandlord { get; set; }
         public string _AddressOfLandlord { get; set; }
        public string _ContactOfLandlord { get; set;}
        public string _AgentName { get; set; }
        public string _HouseNumber { get; set; }
        public string _Locality { get; set;}
        public string _TypeOfPremises { get; set;}
        public DateTime _Commencement { get; set; }
        public string _RecoverableRent { get; set; }
        public int _CustomerId { get; set; }
    }
}
