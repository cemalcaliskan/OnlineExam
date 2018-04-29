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
    public class UserRoleService : IUserRoleSercive
    {
        EFUserRoleDAL _userRoleDAL;

        public UserRoleService()
        {
            _userRoleDAL = new EFUserRoleDAL();
        }
        public void Add(UserRole entity)
        {
            _userRoleDAL.Add(entity);
        }

        public void Delete(UserRole entity)
        {
            entity.IsActive = false;
            _userRoleDAL.Update(entity);
        }

        public UserRole GetByID(int id)
        {
            return _userRoleDAL.Get(a => a.UserRoleID == id && a.IsActive);
        }

        public UserRole GetByRoleName(string role)
        {
            return _userRoleDAL.Get(a => a.Role == role);
        }

        public ICollection<UserRole> GetList()
        {
            return _userRoleDAL.GetAll();
        }

        public void Update(UserRole entity)
        {
            _userRoleDAL.Update(entity);
        }
    }
}
