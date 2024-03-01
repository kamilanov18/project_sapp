using Models.DTOs.Internal;
using Models.DTOs.Internal.Users;

namespace Services.Internal
{
    public interface IRoleService
    {
        IQueryable<NomenclatureDTO<int>> GetAll();
        NomenclatureDTO<int> Get(int id);
        NomenclatureDTO<int> Get(string name);
        void AddOrEdit(NomenclatureDTO<int> dto);
        void Delete(int id);

        IQueryable<UserDTO> GetAllUsersInRole(int id);
        IQueryable<NomenclatureDTO<int>> GetAUsersRoles(int id);

        void AssignUserToRole(int userId, int roleId);
        void AssignUserToRole(UserDTO userDTO, NomenclatureDTO<int> roleDTO);
        void RemoveUserFromRole(int userId, int roleId);
        void RemoveUserFromRole(UserDTO userDTO, NomenclatureDTO<int> roleDTO);
        void UpdateUserRoles(UpdateUserRolesDTO dto);
    }
}
