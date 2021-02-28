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
    public class UrunTakipManager : IUrunTakipService
    {
        IUrunTakipDal dal;
        UrunTakipValidator validator;
        public UrunTakipManager()
        {
            dal = InstanceFactory.Get<IUrunTakipDal>();
            validator = new UrunTakipValidator();
        }

        public void Add(UrunTakip entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(UrunTakip entity)
        {
            dal.Delete(entity);
        }

        public UrunTakip Get(Expression<Func<UrunTakip, bool>> filter)
        {
            return dal.Get(filter);
        }

        public List<UrunTakip> List(Expression<Func<UrunTakip, bool>> filter = null)
        {
            return dal.List(filter);
        }

        public void Update(UrunTakip entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
