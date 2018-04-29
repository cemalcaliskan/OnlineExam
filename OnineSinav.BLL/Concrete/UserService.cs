using OnineSinav.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineSinav.Model;
using OnlineSinav.DAL.Concrete.EntityFramework.DAL;

namespace OnineSinav.BLL.Concrete
{
    public class UserService : IUserService
    {
        EFUserDAL _userDAL;

        public UserService()
        {
            _userDAL = new EFUserDAL();
        }
        public void Add(User entity)
        {
            _userDAL.Add(entity);
        }

        public void Delete(User entity)
        {
            entity.IsActive = false;
            _userDAL.Update(entity);
        }

        public User GetByActivationCode(Guid code)
        {
            return _userDAL.Get(a => a.ActivationCode == code);
        }

        public User GetByID(int id)
        {
            return _userDAL.Get(a => a.UserID == id && a.IsActive);
        }

        public User GetByMailAndPassword(string mail, string passsword)
        {
            return _userDAL.Get(a => a.Email == mail && a.Password == passsword);
        }

        public ICollection<User> GetList()
        {
            return _userDAL.GetAll();
        }

        public void Update(User entity)
        {
            _userDAL.Update(entity);
        }
    }
}
