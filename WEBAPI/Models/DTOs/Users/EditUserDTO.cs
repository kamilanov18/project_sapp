namespace Models.DTOs.Internal.Users
{
    public class EditUserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal? Wage { get; set; }
        public string Phone { get; set; }
    }
}
