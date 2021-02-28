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
    public class UrunKabulManager : IUrunKabulService
    {
        IUrunKabulDal dal;
        UrunKabulValidator validator;
        public UrunKabulManager()
        {
            dal = InstanceFactory.Get<IUrunKabulDal>();
            validator = new UrunKabulValidator();
        }

        public void Add(UrunKabul entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(UrunKabul entity)
        {
            dal.Delete(entity);
        }

        public UrunKabul Get(Expression<Func<UrunKabul, bool>> filter)
        {
            return dal.GetForUrunKabul(filter);
        }

        public List<UrunKabul> List(Expression<Func<UrunKabul, bool>> filter = null)
        {
            return dal.ListForUrunKabul(filter);
        }

        public void Update(UrunKabul entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
