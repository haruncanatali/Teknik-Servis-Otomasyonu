using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Business.Abstract;
using TeknikServis.Business.Fluent_Validation;
using TeknikServis.Business.Ninject;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Concrete
{
    public class DepartmanManager : IDepartmanService
    {
        IDepartmanDal dal;
        DepartmanValidator validator;


        public DepartmanManager()
        {
            dal = InstanceFactory.Get<IDepartmanDal>();
            validator = new DepartmanValidator();
        }


        public void Add(Departman entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(Departman entity)
        {
            dal.Delete(entity);
        }

        public Departman Get(Expression<Func<Departman, bool>> filter)
        {
            return dal.GetForDepartman(filter);
        }

        public List<Departman> List(Expression<Func<Departman, bool>> filter = null)
        {
            return dal.ListForDepartman(filter);
        }

        public void Update(Departman entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
