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
    public class MusteriManager : IMusteriService
    {
        IMusteriDal dal;
        MusteriValidator validator;
        public MusteriManager()
        {
            dal = InstanceFactory.Get<IMusteriDal>();
            validator = new MusteriValidator();
        }

        public void Add(Musteri entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(Musteri entity)
        {
            dal.Delete(entity);
        }

        public Musteri Get(Expression<Func<Musteri, bool>> filter)
        {
            return dal.GetForMusteri(filter);
        }

        public List<Musteri> List(Expression<Func<Musteri, bool>> filter = null)
        {
            return dal.ListForMusteri(filter);
        }

        public void Update(Musteri entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
