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
    public class ArizaDetayManager : IArizaDetayService
    {
        IArizaDetayDal dal;
        ArizaDetayValidator validator;


        public ArizaDetayManager()
        {
            dal = InstanceFactory.Get<IArizaDetayDal>();
            validator = new ArizaDetayValidator();
        }


        public void Add(ArizaDetay entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(ArizaDetay entity)
        {
            dal.Delete(entity);
        }

        public ArizaDetay Get(Expression<Func<ArizaDetay, bool>> filter)
        {
            return dal.Get(filter);
        }

        public List<ArizaDetay> List(Expression<Func<ArizaDetay, bool>> filter = null)
        {
            return dal.List(filter);
        }

        public void Update(ArizaDetay entity)
        {
            ValidationTool.Validate(validator, entity);
            throw new NotImplementedException();
        }
    }
}
