using Models.DTOs.Internal.Users;

namespace Models.DTOs.Internal.Roles
{
    public class UserRolesDTO
    {
        public int UserId { get; set; }
        public List<int> RoleIds { get; set; }
    }
}
