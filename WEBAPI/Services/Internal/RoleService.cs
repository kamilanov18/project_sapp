using DataAccess.Data;
using Models.DTOs.Internal;
using Models.DTOs.Internal.Users;

namespace Services.Internal
{
    public class RoleService : IRoleService
    {
        BizlabbgIcanContext _ctx;
        public RoleService(BizlabbgIcanContext ctx)
        {
            _ctx = ctx;
        }

        public void AddOrEdit(NomenclatureDTO<int> dto)
        {
            IcaksSappRole role;
            if (dto.Id == 0)
            {
                role = new();
                _ctx.IcaksSappRoles.Add(role);
            }
            else
            {
                role = _ctx.IcaksSappRoles.Where(x => x.Id == dto.Id).First();
            }

            role.Name = dto.Name;

            _ctx.SaveChanges();
        }

        public void AssignUserToRole(int userId, int roleId)
        {
            _ctx.IcaksSappUsersRoles.Add(new IcaksSappUsersRole() { RoleId = roleId, UserId = userId });
            _ctx.SaveChanges();
        }

        public void AssignUserToRole(UserDTO userDTO, NomenclatureDTO<int> roleDTO)
        {
            AssignUserToRole(userDTO.Id, roleDTO.Id);
        }

        public void Delete(int id)
        {
            _ctx.Remove(_ctx.IcaksSappRoles.Where(x => x.Id == id).First());
            _ctx.SaveChanges();
        }

        public NomenclatureDTO<int> Get(int id)
        {
            return (from roles in _ctx.IcaksSappRoles
                    where roles.Id == id
                    select new NomenclatureDTO<int>() { Id = id, Name = roles.Name }
                    ).First();
        }

        public NomenclatureDTO<int> Get(string name)
        {
            return (from roles in _ctx.IcaksSappRoles
                    where roles.Name == name
                    select new NomenclatureDTO<int>() { Id = roles.Id, Name = roles.Name }
                    ).First();
        }

        public IQueryable<NomenclatureDTO<int>> GetAll()
        {
            return (from roles in _ctx.IcaksSappRoles
                    select new NomenclatureDTO<int>() { Id = roles.Id, Name = roles.Name }
                    );
        }

        public IQueryable<UserDTO> GetAllUsersInRole(int roleId)
        {
            return (from roles in _ctx.IcaksSappRoles
                    join userRoles in _ctx.IcaksSappUsersRoles on roles.Id equals roleId
                    join users in _ctx.IcaksSappUsers on userRoles.RoleId equals roleId
                    select new UserDTO() 
                    { 
                        Id = users.Id,
                        Email = users.Email,
                        FirstName = users.FirstName,
                        LastName = users.LastName,
                        Phone = users.Phone,
                        Wage = users.Wage
                    }).Distinct();
        }

        public void RemoveUserFromRole(int userId, int roleId)
        {
            _ctx.IcaksSappUsersRoles.Remove(_ctx.IcaksSappUsersRoles.Where(x=>x.UserId==userId&&x.RoleId==roleId).First());
            _ctx.SaveChanges();
        }

        public void RemoveUserFromRole(UserDTO userDTO, NomenclatureDTO<int> roleDTO)
        {
            RemoveUserFromRole(userDTO.Id, roleDTO.Id);
        }

        public void UpdateUserRoles(UpdateUserRolesDTO dto)
        {
            foreach(var oneDtoUserRoles in dto.userRoles)
            {
                var toBeDeleted = _ctx.IcaksSappUsersRoles.Where(x=>x.UserId==oneDtoUserRoles.UserId).ToList().Except(
                    _ctx.IcaksSappUsersRoles.Where(x => 
                        oneDtoUserRoles.RoleIds.Contains(x.RoleId)
                    )
                );

                var toBeAddedIds = oneDtoUserRoles.RoleIds.Except(_ctx.IcaksSappUsersRoles.Select(x => x.RoleId));

                _ctx.RemoveRange(toBeDeleted);
                _ctx.IcaksSappUsersRoles.AddRange(toBeAddedIds.Select(x => 
                    new IcaksSappUsersRole() { UserId = oneDtoUserRoles.UserId, RoleId = x }
                ));
            }

            _ctx.SaveChanges();
        }

        public IQueryable<NomenclatureDTO<int>> GetAUsersRoles(int userId)
        {
            return (from roles in _ctx.IcaksSappRoles
                    join userRoles in _ctx.IcaksSappUsersRoles on roles.Id equals userRoles.RoleId
                    join users in _ctx.IcaksSappUsers on userRoles.UserId equals userId
                    where users.Id==userId
                    select new NomenclatureDTO<int>() { Id = roles.Id, Name=roles.Name });
        }
    }
}
