using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.DataAccess.Abstract;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.DataAccess.Concrete.EntityFramework
{
    public class DepartmanDal : EntityRepositoryBase<Departman, TeknikServisDbContext>, IDepartmanDal
    {
        TeknikServisDbContext context = new TeknikServisDbContext();
        public Departman GetForDepartman(Expression<Func<Departman, bool>> filter)
        {
            return context.Departman.Include(c=>c.Personeller).SingleOrDefault(filter);
        }

        public List<Departman> ListForDepartman(Expression<Func<Departman, bool>> filter = null)
        {
            return filter == null ? context.Departman.Include(c => c.Personeller).ToList() : context.Departman.Include(c => c.Personeller).Where(filter).ToList();
        }
    }
}
