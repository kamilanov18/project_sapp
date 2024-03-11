using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models.DTOs.Internal.Users;
using Models.DTOs.Users;
using System.Security.Cryptography;
using System.Text;

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
            using (HMACSHA256 sha = new())
            {
                _ctx.IcaksSappUsers.Find(dto.Id).PasswordHash = sha.ComputeHash(Encoding.UTF8.GetBytes(dto.PasswordHash)).ToString();
                _ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            _ctx.Remove(_ctx.IcaksSappUsers.Where(x => x.Id == id).First());
            _ctx.SaveChanges();
        }

        public void Edit(EditUserDTO dto)
        {
            if (_ctx.IcaksSappUsers.Where(x => x.Email == dto.Email).Any())
            {
                throw new InvalidDataException("email-must-be-unique");
            }

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
                    ).AsNoTracking().First();
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
                    ).AsNoTracking();
        }

        public void Register(EditUserDTO dto)
        {
            if(_ctx.IcaksSappUsers.Where(x=>x.Email==dto.Email).Any())
            {
                throw new InvalidDataException("errors.email-must-be-unique");
            }

            if (_ctx.IcaksSappUsers.Where(x => x.Phone == dto.Phone).Any())
            {
                throw new InvalidDataException("errors.phone-must-be-unique");
            }

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
