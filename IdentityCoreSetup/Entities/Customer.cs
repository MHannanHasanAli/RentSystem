using System.ComponentModel.DataAnnotations;

namespace IdentityCoreSetup.Entities
{
    public class Customer
    {
        [Key]
        public int _Id { get; set; }  
       
        public DateTime _DateOfBirth { get; set; }
        public string? _MaritalStatus { get; set; }
        public int? _Children { get; set; }
        public string? _ContactNo { get; set; }
        public DateTime _TenancyBegan { get; set; }
        public string? _Nationality { get; set; }
        public string? _HomeTown { get; set; }
        public string? _Occupation { get; set; }
        public string? _MName { get; set; }
        public string? _MAddress { get; set; }
        public string? _MContactNo { get; set; }
        public string? _MOccupation { get; set; }
        public string? _EName { get; set; }
        public string? _EAddress { get; set; }
        public string? _EContactNo { get; set; }
        public string? _EPosition { get; set; }
        public string? _FName { get; set; }
        public string? _FAddress { get; set; }
        public string? _FContactNo { get; set; }
        public string? _FOccupation { get; set; }
        public string? _UName { get; set; }
        public string? _UAddress { get; set; }
        public string? _UContactNo { get; set; }
        public string? _UOccupation { get; set; }
        public string? _URelation { get; set; }

        

        //public decimal? _TotalRent { get; set; }
        //public string? _TypeOfRent { get; set; }
        //public DateTime _NextDueDate { get; set; }
    }
}
