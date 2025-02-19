namespace BackendSQL.DTO
{
    public class Address
    {
        public long AddressId { get; set; }
        public long EmployeeId { get; set; }
        public string? State { get; set; }
        public int Postal { get; set; }
    }
}