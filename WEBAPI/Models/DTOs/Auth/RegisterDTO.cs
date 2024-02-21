namespace Models.DTOs.Auth
{
    public class RegisterDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public float Wage { get; set; }
        public List<int> RoleIds { get; set; }
    }
}
