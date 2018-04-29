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
    public class ExamService : IExamService
    {
        EFExamDAL _examDAL;

        public ExamService()
        {
            _examDAL = new EFExamDAL();
        }

        public void Add(Exam entity)
        {
            _examDAL.Add(entity);
        }

        public void Delete(Exam entity)
        {
            entity.IsActive = false;
            _examDAL.Update(entity);
        }

        public Exam GetByID(int id)
        {
            return _examDAL.Get(a => a.ExamID == id && a.IsActive);
        }

        public ICollection<Exam> GetList()
        {
            return _examDAL.GetAll();
        }

        public void Update(Exam entity)
        {
            _examDAL.Update(entity);
        }
    }
}
