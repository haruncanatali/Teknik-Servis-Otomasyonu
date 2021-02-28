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
    public class UrunManager : IUrunService
    {
        IUrunDal dal;
        UrunValidator validator;
        public UrunManager()
        {
            dal = InstanceFactory.Get<IUrunDal>();
            validator = new UrunValidator();
        }

        public void Add(Urun entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(Urun entity)
        {
            dal.Delete(entity);
        }

        public Urun Get(Expression<Func<Urun, bool>> filter)
        {
            return dal.GetForUrun(filter);
        }

        public List<Urun> List(Expression<Func<Urun, bool>> filter = null)
        {
            return dal.ListForUrun(filter);
        }

        public void Update(Urun entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
