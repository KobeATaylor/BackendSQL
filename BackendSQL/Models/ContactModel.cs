using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendSQL.Models
{
    [Table("Contact")]
    public class ContactModel
    {
        [Key]
        [Column("ContactId")]
        public long ContactId { get; set; }

        [ForeignKey("Employee")]
        [Column("EmployeeId")]
        public long EmployeeId { get; set; }

        [Column("Email")]
        public string? Email { get; set; }

        [Column("Phone")]
        public long Phone { get; set; }


    }
}
