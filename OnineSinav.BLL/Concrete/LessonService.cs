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
    class LessonService : ILessonService
    {
        EFLessonDAL _lessonDAL;

        public LessonService()
        {
            _lessonDAL = new EFLessonDAL();
        }
        public void Add(Lesson entity)
        {
            _lessonDAL.Add(entity);
        }

        public void Delete(Lesson entity)
        {
            entity.IsActive = false;
            _lessonDAL.Update(entity);
        }

        public Lesson GetByID(int id)
        {
            return _lessonDAL.Get(a => a.LessonID == id && a.IsActive);
        }

        public ICollection<Lesson> GetList()
        {
            return _lessonDAL.GetAll();
        }

        public void Update(Lesson entity)
        {
            _lessonDAL.Update(entity);
        }
    }
}
