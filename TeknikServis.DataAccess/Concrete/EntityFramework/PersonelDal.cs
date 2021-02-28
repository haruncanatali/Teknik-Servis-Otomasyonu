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
    public class PersonelDal : EntityRepositoryBase<Personel, TeknikServisDbContext>, IPersonelDal
    {
        TeknikServisDbContext context = new TeknikServisDbContext();
        public Personel GetForPersonel(Expression<Func<Personel, bool>> filter)
        {
            return context.Personel.Include(c=>c.Departman).Include(c => c.FaturaBilgiler).Include(c => c.UrunHareketler).Include(c => c.UrunKabuller).SingleOrDefault(filter);
        }

        public List<Personel> ListForPersonel(Expression<Func<Personel, bool>> filter = null)
        {
            return filter == null ? context.Personel.Include(c => c.FaturaBilgiler).Include(c => c.UrunHareketler).Include(c => c.UrunKabuller).Include(c => c.Departman).ToList() : context.Personel.Include(c => c.FaturaBilgiler).Include(c => c.Departman).Include(c => c.UrunHareketler).Include(c => c.UrunKabuller).Where(filter).ToList();
        }
    }
}
