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
    class UserExamService : IUserExamService
    {
        EFUserExamDAL _userExamDAL;

        public UserExamService()
        {
            _userExamDAL = new EFUserExamDAL();
        }
        public void Add(UserExam entity)
        {
            _userExamDAL.Add(entity);
        }

        public void Delete(UserExam entity)
        {
            entity.IsActive = false;
            _userExamDAL.Update(entity);
        }

        public UserExam GetByID(int id)
        {
            return _userExamDAL.Get(a => a.UserID == id && a.IsActive);
        }

        public ICollection<UserExam> GetList()
        {
            return _userExamDAL.GetAll();
        }

        public void Update(UserExam entity)
        {
            _userExamDAL.Update(entity);
        }
    }
}
