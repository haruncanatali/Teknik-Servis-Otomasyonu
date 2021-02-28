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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal dal;
        PersonelValidator validator;
        public PersonelManager()
        {
            dal = InstanceFactory.Get<IPersonelDal>();
            validator = new PersonelValidator();
        }

        public void Add(Personel entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(Personel entity)
        {
            dal.Delete(entity);
        }

        public Personel Get(Expression<Func<Personel, bool>> filter)
        {
            return dal.GetForPersonel(filter);
        }

        public List<Personel> List(Expression<Func<Personel, bool>> filter = null)
        {
            return dal.ListForPersonel(filter);
        }

        public void Update(Personel entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
