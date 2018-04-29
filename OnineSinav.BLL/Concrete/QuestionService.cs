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
    class QuestionService : IQuestionService
    {
        EFQuestionDAL _questionDAL;
        public QuestionService()
        {
            _questionDAL = new EFQuestionDAL();
        }
        public void Add(Question entity)
        {
            _questionDAL.Add(entity);
        }

        public void Delete(Question entity)
        {
            entity.IsActive = false;
            _questionDAL.Update(entity);
        }

        public Question GetByID(int id)
        {
            return _questionDAL.Get(a => a.QuestionID == id && a.IsActive);
        }

        public ICollection<Question> GetList()
        {
            return _questionDAL.GetAll();
        }

        public void Update(Question entity)
        {
            _questionDAL.Update(entity);
        }
    }
}
