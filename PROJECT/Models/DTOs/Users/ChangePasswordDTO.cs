namespace Models.DTOs.Users
{
    public class ChangePasswordDTO
    {
        public int Id { get; set; }
        public string PasswordHash { get; set; }
    }
}
