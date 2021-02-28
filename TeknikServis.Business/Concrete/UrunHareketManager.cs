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
    public class UrunHareketManager : IUrunHareketService
    {
        IUrunHareketDal dal;
        UrunHareketValidator validator;
        public UrunHareketManager()
        {
            dal = InstanceFactory.Get<IUrunHareketDal>();
            validator = new UrunHareketValidator();
        }

        public void Add(UrunHareket entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(UrunHareket entity)
        {
            dal.Delete(entity);
        }

        public UrunHareket Get(Expression<Func<UrunHareket, bool>> filter)
        {
            return dal.GetForUrunHareket(filter);
        }

        public List<UrunHareket> List(Expression<Func<UrunHareket, bool>> filter = null)
        {
            return dal.ListForUrunHareketler(filter);
        }

        public void Update(UrunHareket entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
