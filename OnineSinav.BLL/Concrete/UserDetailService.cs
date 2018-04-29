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
    public class UserDetailService : IUserDetailService
    {
        EFUserDetailDAL _userDetailDAL;

        public UserDetailService()
        {
            _userDetailDAL = new EFUserDetailDAL();
        }
        public void Add(UserDetail entity)
        {
            _userDetailDAL.Add(entity);
        }

        public void Delete(UserDetail entity)
        {
            throw new NotImplementedException();
        }

        public UserDetail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<UserDetail> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(UserDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
