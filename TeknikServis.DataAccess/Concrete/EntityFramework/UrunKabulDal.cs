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
    public class UrunKabulDal : EntityRepositoryBase<UrunKabul, TeknikServisDbContext>, IUrunKabulDal
    {
        public UrunKabul GetForUrunKabul(Expression<Func<UrunKabul, bool>> filter)
        {
            using (TeknikServisDbContext context = new TeknikServisDbContext())
            {
                return context.UrunKabul.Include(c => c.Personel).Include(c => c.Musteri).Include(c => c.Urun).FirstOrDefault(filter);
            }
        }

        public List<UrunKabul> ListForUrunKabul(Expression<Func<UrunKabul, bool>> filter = null)
        {
            using (TeknikServisDbContext context = new TeknikServisDbContext())
            {
                return filter == null ? context.UrunKabul.Include(c => c.Personel).Include(c => c.Musteri).Include(c => c.Urun).ToList() : context.UrunKabul.Include(c => c.Personel).Include(c => c.Musteri).Include(c => c.Urun).Where(filter).ToList();
            }
        }
    }
}
