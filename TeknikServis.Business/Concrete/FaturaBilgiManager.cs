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
    public class FaturaBilgiManager : IFaturaBilgiService
    {
        IFaturaBilgiDal dal;
        FaturaBilgiValidator validator;

        public FaturaBilgiManager()
        {
            dal = InstanceFactory.Get<IFaturaBilgiDal>();
            validator = new FaturaBilgiValidator();
        }

        public void Add(FaturaBilgi entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(FaturaBilgi entity)
        {
            dal.Delete(entity);
        }

        public FaturaBilgi Get(Expression<Func<FaturaBilgi, bool>> filter)
        {
            return dal.GetForFaturaBilgi(filter);
        }

        public List<FaturaBilgi> List(Expression<Func<FaturaBilgi, bool>> filter = null)
        {
            return dal.ListForFaturaBilgi(filter);
        }

        public void Update(FaturaBilgi entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
