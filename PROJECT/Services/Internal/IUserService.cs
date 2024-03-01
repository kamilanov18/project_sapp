using Models.DTOs.Internal.Users;
using Models.DTOs.Users;

namespace Services.Internal
{
    public interface IUserService
    {
        UserDTO Get(int id);
        IQueryable<UserDTO> GetAll();
        void Edit(EditUserDTO dto);
        void Register(EditUserDTO dto);
        void Delete(int id);
        void ChangePassword(ChangePasswordDTO dto);
    }
}
