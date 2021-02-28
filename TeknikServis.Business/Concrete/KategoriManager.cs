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
    public class KategoriManager : IKategoriService
    {
        IKategoriDal dal;
        KategoriValidator validator;
        public KategoriManager()
        {
            dal = InstanceFactory.Get<IKategoriDal>();
            validator = new KategoriValidator();
        }

        public void Add(Kategori entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Add(entity);
        }

        public void Delete(Kategori entity)
        {
            dal.Delete(entity);
        }

        public Kategori Get(Expression<Func<Kategori, bool>> filter)
        {
            return dal.GetForKategori(filter);
        }

        public List<Kategori> List(Expression<Func<Kategori, bool>> filter = null)
        {
            return dal.ListForKategori(filter);
        }

        public void Update(Kategori entity)
        {
            ValidationTool.Validate(validator, entity);
            dal.Update(entity);
        }
    }
}
