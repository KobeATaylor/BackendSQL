namespace BackendSQL.DTO
{
    public class Contact
    {
        public long ContactID { get; set; }
        public long EmployeeId { get; set; }
        public string? Email { get; set; }
        public int Phone { get; set; }

    }
}
