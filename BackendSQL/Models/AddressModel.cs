using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendSQL.Models
{
    [Table("Address")]
    public class AddressModel
    {
        [Key]
        [Column("AddressId")]
        public long AddressId { get; set; }

        [ForeignKey(("Employee"))]
        [Column("EmployeeId")]
        public long EmployeeId { get; set; }

        public EmployeeModel? Employee { get; set; }

        [Column("State")]
        public string? State { get; set; }

        [Column("Postal")]
        public int Postal { get; set; }
    }
}