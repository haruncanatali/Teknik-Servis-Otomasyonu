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
    public class FaturaDetayManager : IFaturaDetayService
    {
        IFaturaDetayDal dal;
        FaturaDetayValidator validator;
        public FaturaDetayManager()
        {
            dal = InstanceFactory.Get<IFaturaDetayDal>();
            validator = new FaturaDetayValidator();
        }

        public void Add(FaturaDetay entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(FaturaDetay entity)
        {
            dal.Delete(entity);
        }

        public FaturaDetay Get(Expression<Func<FaturaDetay, bool>> filter)
        {
            return dal.GetForFaturaDetay(filter);
        }

        public List<FaturaDetay> List(Expression<Func<FaturaDetay, bool>> filter = null)
        {
            return dal.ListForFaturaDetay(filter);
        }

        public void Update(FaturaDetay entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
