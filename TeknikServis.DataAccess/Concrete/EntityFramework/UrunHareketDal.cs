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
    public class UrunHareketDal : EntityRepositoryBase<UrunHareket, TeknikServisDbContext>, IUrunHareketDal
    {
        public UrunHareket GetForUrunHareket(Expression<Func<UrunHareket, bool>> filter)
        {
            using (TeknikServisDbContext context = new TeknikServisDbContext())
            {
               return context.UrunHareket.Include(c=>c.Musteri).Include(c=>c.Personel).Include(c=>c.Urun).FirstOrDefault(filter);
            }
        }

        public List<UrunHareket> ListForUrunHareketler(Expression<Func<UrunHareket, bool>> filter = null)
        {
            using (TeknikServisDbContext context = new TeknikServisDbContext())
            {
                return filter == null ? context.UrunHareket.Include(c => c.Musteri).Include(c => c.Personel).Include(c => c.Urun).ToList() : context.UrunHareket.Include(c => c.Musteri).Include(c => c.Personel).Include(c => c.Urun).Where(filter).ToList();
            }
        }
    }
}
