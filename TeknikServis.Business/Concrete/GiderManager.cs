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
    public class GiderManager : IGiderService
    {
        IGiderDal dal;
        GiderValidator validator;
        public GiderManager()
        {
            dal = InstanceFactory.Get<IGiderDal>();
            validator = new GiderValidator();
        }

        public void Add(Gider entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(Gider entity)
        {
            dal.Delete(entity);
        }

        public Gider Get(Expression<Func<Gider, bool>> filter)
        {
            return dal.Get(filter);
        }

        public List<Gider> List(Expression<Func<Gider, bool>> filter = null)
        {
            return dal.List(filter);
        }

        public void Update(Gider entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
