using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace BackendSQL.Models
{
    [Table("Employee")]
    public class EmployeeModel
    {
        [Key]
        [Column("EmployeeId")]
        public int EmployeeId { get; set; }

        [Column("FirstName")]
        public string? FirstName { get; set; }

        [Column("LastName")]
        public string? LastName { get; set; }
    }
}
