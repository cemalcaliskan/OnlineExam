using OnineSinav.BLL.Abstract;
using OnineSinav.BLL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineSinav.Model;
using OnlineSinav.DAL.Concrete.EntityFramework.DAL;

namespace OnineSinav.BLL.Concrete
{
    class ChoiceService : IChoiceServive
    {
        EFChoiceDAL _choiceDAL;

        public ChoiceService()
        {
            _choiceDAL = new EFChoiceDAL();
        }

        public void Add(Choice entity)
        {
            _choiceDAL.Add(entity);
        }

        public void Delete(Choice entity)
        {
            entity.IsActive = false;
            _choiceDAL.Update(entity);
        }

        public Choice GetByID(int id)
        {
            return _choiceDAL.Get(a => a.ChoiceID == id && a.IsActive);
        }

        public ICollection<Choice> GetList()
        {
            return _choiceDAL.GetAll();
        }

        public void Update(Choice entity)
        {
            _choiceDAL.Update(entity);
        }
    }
}
