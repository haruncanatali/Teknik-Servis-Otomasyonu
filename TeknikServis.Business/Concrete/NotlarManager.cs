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
    public class NotlarManager : INotlarService
    {
        INotlarDal dal;
        NotlarValidator validator;

        public NotlarManager()
        {
            dal = InstanceFactory.Get<INotlarDal>();
            validator = new NotlarValidator();
        }


        public void Add(Notlar entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(Notlar entity)
        {
            dal.Delete(entity);
        }

        public Notlar Get(Expression<Func<Notlar, bool>> filter)
        {
            return dal.Get(filter);
        }

        public List<Notlar> List(Expression<Func<Notlar, bool>> filter = null)
        {
            return dal.List(filter);
        }

        public void Update(Notlar entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
