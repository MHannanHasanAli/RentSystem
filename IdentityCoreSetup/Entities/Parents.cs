using System.ComponentModel.DataAnnotations;

namespace IdentityCoreSetup.Entities
{
    public class Parents
    {
        [Key]
        public int _Id { get; set; }
        public int _CustomerId { get; set; }
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
    }
}
