using DataAccess.Data;
using Models.DTOs.Internal.Users;
using Models.DTOs.Users;

namespace Services.Internal
{
    public class UserService: IUserService
    {
        BizlabbgIcanContext _ctx;
        public UserService(BizlabbgIcanContext ctx)
        {
            _ctx = ctx;
        }

        public void ChangePassword(ChangePasswordDTO dto)
        {
            _ctx.IcaksSappUsers.Find(dto.Id).PasswordHash = dto.PasswordHash;
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            _ctx.Remove(_ctx.IcaksSappUsers.Where(x => x.Id == id).First());
            _ctx.SaveChanges();
        }

        public void Edit(EditUserDTO dto)
        {
            IcaksSappUser user = _ctx.Find<IcaksSappUser>(dto.Id);
            user.Email = dto.Email;
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.PasswordHash = null;
            user.Phone = dto.Phone;
            user.Wage = dto.Wage;

            _ctx.SaveChanges();
        }

        public UserDTO Get(int id)
        {
            return (from users in _ctx.IcaksSappUsers
                    where users.Id == id
                    select new UserDTO()
                    {
                        Id= id,
                        Email=users.Email,
                        FirstName=users.FirstName,
                        LastName=users.LastName,
                        Phone=users.Phone,
                        Wage=users.Wage
                    }
                    ).First();
        }

        public IQueryable<UserDTO> GetAll()
        {
            return (from users in _ctx.IcaksSappUsers
                    select new UserDTO()
                    {
                        Id = users.Id,
                        Email = users.Email,
                        FirstName = users.FirstName,
                        LastName = users.LastName,
                        Phone = users.Phone,
                        Wage = users.Wage
                    }
                    );
        }

        public void Register(EditUserDTO dto)
        {
            IcaksSappUser user = new()
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PasswordHash = null,
                Phone=dto.Phone,
                Wage=dto.Wage,
            };

            _ctx.IcaksSappUsers.Add(user);
            _ctx.SaveChanges();
        }
    }
}
